Imports System.IO
Imports Id3
Public Class Form1
    Private Function FormatFileSize(ByVal FileSizeBytes As Long) As String
        Dim sizeTypes() As String = {"b", "Kb", "Mb", "Gb"}
        Dim Len As Decimal = FileSizeBytes
        Dim sizeType As Integer = 0
        Do While Len > 1024
            Len = Decimal.Round(Len / 1024, 2)
            sizeType += 1
            If sizeType >= sizeTypes.Length - 1 Then Exit Do
        Loop
        Dim Resp As String = Len.ToString & " " & sizeTypes(sizeType)
        Return Resp
    End Function

    Private Sub GetDrives()
        tvDrive.Nodes.Clear()

        For Each Drive In DriveInfo.GetDrives
            If (Drive.IsReady) Then
                Dim dName As String = Drive.VolumeLabel
                If String.IsNullOrEmpty(dName) Then
                    dName = Drive.Name
                End If
                Dim tNode As New TreeNode()
                With tNode
                    .ImageIndex = 0
                    .SelectedImageIndex = 0
                    .Text = dName
                    .Nodes.Add("")
                    .Tag = Drive.Name
                End With
                Call tvDrive.Nodes.Add(tNode)
            End If
        Next
    End Sub

    Private Sub GetFolders(ByVal PathName As TreeNode)
        Dim di As DirectoryInfo
        PathName.Nodes.Clear()
        di = New DirectoryInfo(PathName.Tag)
        Try
            For Each nFolder In di.GetDirectories()
                Dim tNode As New TreeNode()
                With tNode
                    .ImageIndex = 1
                    .SelectedImageIndex = 1
                    .Tag = nFolder.FullName
                    .Text = nFolder.Name.ToString()
                    .Nodes.Add("")
                End With
                di = New DirectoryInfo(tNode.Tag)
                If (di.Attributes And FileAttributes.Hidden) = False Then
                    PathName.Nodes.Add(tNode)
                End If
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub GetFiles(ByVal PathName As String)
        Dim LItem As ListViewItem
        LvMP3.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
        LvMP3.Items.Clear()
        LvMP3.BeginUpdate()
        For Each nFile As String In Directory.GetFiles(PathName)
            Dim sExtension As String = Path.GetExtension(nFile)
            sExtension = sExtension.ToLower
            Dim f As FileInfo = New FileInfo(nFile)
            Dim att As String = f.Attributes.ToString
            Dim size As String = f.Length.ToString
            Dim dibuat As String = f.CreationTime.ToString
            Dim akses As String = f.LastAccessTime.ToString
            Dim modi As String = f.LastWriteTime.ToString
            If (Trim(sExtension) = ".mp3" = True) Then
                LItem = New ListViewItem()
                Dim iconForFile As Icon = SystemIcons.WinLogo
                If Not (ImageList1.Images.ContainsKey(sExtension)) Then
                    iconForFile = System.Drawing.Icon.ExtractAssociatedIcon(nFile)
                    ImageList1.Images.Add(sExtension, iconForFile)
                End If
                With LItem
                    .SubItems(0).Text = Path.GetFileNameWithoutExtension(nFile)
                    .SubItems.Add(sExtension)
                    .SubItems.Add(FormatFileSize(size))
                    .SubItems.Add(modi)
                    .SubItems.Add(akses)
                    .SubItems.Add(dibuat)
                    .SubItems.Add(att)
                    .ImageKey = sExtension
                    .Tag = Path.Combine(PathName, nFile)
                End With
                LvMP3.Items.Add(LItem)
            End If
        Next
        LvMP3.EndUpdate()
        For Each x As ColumnHeader In LvMP3.Columns
            x.Width = -2
        Next
    End Sub

    Private Sub tvDrive_BeforeExpand(sender As Object, e As TreeViewCancelEventArgs) Handles tvDrive.BeforeExpand
        GetFolders(e.Node)
    End Sub

    Private Sub tvDrive_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvDrive.AfterSelect
        GetFiles(e.Node.Tag)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetDrives()
        LvMP3.Columns(0).Width = -2
    End Sub

    Private Sub LvMP3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LvMP3.SelectedIndexChanged
        AxWindowsMediaPlayer1.settings.autoStart = False
        If LvMP3.SelectedItems.Count = 1 Then
            AxWindowsMediaPlayer1.URL = LvMP3.SelectedItems(0).Tag
            lblDuration.Text = AxWindowsMediaPlayer1.currentMedia.durationString
            btnPlay.Text = "Play"
            btnPlay.Enabled = True
            Dim file As Mp3 = New Mp3(LvMP3.SelectedItems(0).Tag.ToString, Mp3Permissions.Read)
            Dim tag As Id3Tag = New Id3Tag()
            If file.HasTags Then
                If file.HasTagOfVersion(Id3Version.V1X) Then
                    tag = file.GetTag(Id3TagFamily.Version1X)
                ElseIf file.HasTagOfVersion(Id3Version.V23) Then
                    tag = file.GetTag(Id3TagFamily.Version2X)
                End If
                txtTrack.Text = tag.Track
                txtTitle.Text = tag.Title
                If tag.Artists.Value.Count > 0 Then
                    txtArtist.Text = tag.Artists.Value(0)
                End If
                txtAlbum.Text = tag.Album
                txtYear.Text = tag.Year
                Label11.Text = ""
            Else
                Label11.Text = "ID3 tag not found."
                txtTrack.Clear()
                txtTitle.Clear()
                txtArtist.Clear()
                txtAlbum.Clear()
                txtYear.Clear()
            End If
            file.Dispose()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblPlaying.Text = AxWindowsMediaPlayer1.Ctlcontrols.currentPositionString
        lblDuration.Text = AxWindowsMediaPlayer1.currentMedia.durationString
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        If AxWindowsMediaPlayer1.URL <> "" Then
            If btnPlay.Text = "Play" And AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsReady Then
                AxWindowsMediaPlayer1.Ctlcontrols.play()
                Timer1.Enabled = True
                btnPlay.Text = "Pause"
            ElseIf btnPlay.Text = "Pause" And AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsPlaying Then
                AxWindowsMediaPlayer1.Ctlcontrols.pause()
                Timer1.Enabled = False
                btnPlay.Text = "Play"
            ElseIf btnPlay.Text = "Play" And AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsPaused Then
                AxWindowsMediaPlayer1.Ctlcontrols.play()
                Timer1.Enabled = True
                btnPlay.Text = "Pause"
            End If
            btnStop.Enabled = True
        End If
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        If AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsPlaying Or AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsPaused Then
            AxWindowsMediaPlayer1.Ctlcontrols.stop()
            Timer1.Enabled = False
            btnPlay.Text = "Play"
            lblPlaying.Text = "00:00"
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If btnEdit.Text = "Edit" Then
            txtTrack.ReadOnly = False
            txtTitle.ReadOnly = False
            txtArtist.ReadOnly = False
            txtAlbum.ReadOnly = False
            txtYear.ReadOnly = False
            btnEdit.Text = "Save"
        Else
            If AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsPlaying Or AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsPaused Or AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsReady Or AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsStopped Then
                AxWindowsMediaPlayer1.Ctlcontrols.stop()
                Timer1.Enabled = False
                btnPlay.Text = "Play"
                lblPlaying.Text = "00:00"
                AxWindowsMediaPlayer1.close()
                AxWindowsMediaPlayer1.URL = ""
            End If
            Dim file As Mp3 = New Mp3(LvMP3.SelectedItems(0).Tag.ToString, Mp3Permissions.ReadWrite)
            Try
                Dim tag As Id3Tag = New Id3Tag()
                If file.HasTagOfVersion(Id3Version.V1X) Then
                    tag = file.GetTag(Id3TagFamily.Version1X)
                ElseIf file.HasTagOfVersion(Id3Version.V23) Then
                    tag = file.GetTag(Id3TagFamily.Version2X)
                End If
                If txtTrack.Text.Length > 0 Then
                    If tag.Track.IsAssigned Then
                        tag.Track.Value = Val(txtTrack.Text)
                    Else
                        Dim x As Frames.TrackFrame = New Frames.TrackFrame()
                        x.Value = Val(txtTrack.Text)
                        tag.Append(x)
                    End If
                End If
                If txtTitle.Text.Length > 0 Then
                    If tag.Title.IsAssigned Then
                        tag.Title.Value = txtTitle.Text
                    Else
                        Dim x As Frames.TitleFrame = New Frames.TitleFrame()
                        x.Value = txtTitle.Text
                        tag.Append(x)
                    End If
                End If
                If txtArtist.Text.Length > 0 Then
                    If tag.Artists.IsAssigned Then
                        tag.Artists.Value.Add(txtArtist.Text)
                    Else
                        Dim x As Frames.ArtistsFrame = New Frames.ArtistsFrame
                        x.Value.Add(txtArtist.Text)
                        tag.Append(x)
                    End If
                End If
                If txtAlbum.Text.Length > 0 Then
                    If tag.Album.IsAssigned Then
                        tag.Album.Value = txtAlbum.Text
                    Else
                        Dim x As Frames.AlbumFrame = New Frames.AlbumFrame
                        x.Value = txtAlbum.Text
                        tag.Append(x)
                    End If
                End If
                If txtYear.Text.Length > 0 Then
                    If tag.Year.IsAssigned Then
                        tag.Year.Value = Val(txtYear.Text)
                    Else
                        Dim x As Frames.YearFrame = New Frames.YearFrame
                        x.Value = Val(txtYear.Text)
                        tag.Append(x)
                    End If
                End If
                file.WriteTag(tag, WriteConflictAction.Replace)
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                txtTrack.ReadOnly = True
                txtTitle.ReadOnly = True
                txtArtist.ReadOnly = True
                txtAlbum.ReadOnly = True
                txtYear.ReadOnly = True
                file.Dispose()
            End Try
            btnEdit.Text = "Edit"
        End If
    End Sub
End Class
