<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GPSDataTabControl = New System.Windows.Forms.TabControl()
        Me.GPSDataTabPage = New System.Windows.Forms.TabPage()
        Me.GPSDataTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.GGAGroupBox = New System.Windows.Forms.GroupBox()
        Me.GGATableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.GGAUTCTimeTitleLabel = New System.Windows.Forms.Label()
        Me.GGAUTCTimeValueLabel = New System.Windows.Forms.Label()
        Me.GGALatitudeTitleLabel = New System.Windows.Forms.Label()
        Me.GGALatitudeValueLabel = New System.Windows.Forms.Label()
        Me.GGALogitudeTitleLabel = New System.Windows.Forms.Label()
        Me.GGALogitudeValueLabel = New System.Windows.Forms.Label()
        Me.GGAPosFixTitleLabel = New System.Windows.Forms.Label()
        Me.GGAPosFixValueLabel = New System.Windows.Forms.Label()
        Me.GGASatellitesUsedTitleLabel = New System.Windows.Forms.Label()
        Me.GGASatellitesUsedValueLabel = New System.Windows.Forms.Label()
        Me.GGAHDOPTitleLabel = New System.Windows.Forms.Label()
        Me.GGAHDOPValueLabel = New System.Windows.Forms.Label()
        Me.GGAMSLAltitudeTitleLabel = New System.Windows.Forms.Label()
        Me.GGAMSLAltitudeValueLabel = New System.Windows.Forms.Label()
        Me.GGAGeoindSepTitleLabel = New System.Windows.Forms.Label()
        Me.GGAGeoindSepValueLabel = New System.Windows.Forms.Label()
        Me.GGAElipsoidAltitudeTitleLabel = New System.Windows.Forms.Label()
        Me.GGAElipsoidAltitudeValueLabel = New System.Windows.Forms.Label()
        Me.GGAAgeDiffCorrTitleLabel = New System.Windows.Forms.Label()
        Me.GGAAgeDiffCorrValueLabel = New System.Windows.Forms.Label()
        Me.GGADiffRefStationIDTitleLabel = New System.Windows.Forms.Label()
        Me.GGADiffRefStationIDValueLabel = New System.Windows.Forms.Label()
        Me.GPSRawDataLabel = New System.Windows.Forms.Label()
        Me.GLLGroupBox = New System.Windows.Forms.GroupBox()
        Me.GLLTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.GLLDescriptionLabel = New System.Windows.Forms.Label()
        Me.GLLUTCTimeTitleLabel = New System.Windows.Forms.Label()
        Me.GLLUTCTimeValueLabel = New System.Windows.Forms.Label()
        Me.MapTabPage = New System.Windows.Forms.TabPage()
        Me.stopButton = New System.Windows.Forms.Button()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.getGPSDataTimer = New System.Windows.Forms.Timer(Me.components)
        Me.MainTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonsFlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.SetComPortGroupBox = New System.Windows.Forms.GroupBox()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.ConfigPortTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.ComPortComboBox = New System.Windows.Forms.ComboBox()
        Me.ComPortLabel = New System.Windows.Forms.Label()
        Me.ComPortBaudRateLabel = New System.Windows.Forms.Label()
        Me.ComPortBaudRateComboBox = New System.Windows.Forms.ComboBox()
        Me.ComPortParityLabel = New System.Windows.Forms.Label()
        Me.ComPortParityComboBox = New System.Windows.Forms.ComboBox()
        Me.ComPortDataBitsLabel = New System.Windows.Forms.Label()
        Me.ComPortDataBitsComboBox = New System.Windows.Forms.ComboBox()
        Me.ComPortStopBitsLabel = New System.Windows.Forms.Label()
        Me.ComPortStopBitsComboBox = New System.Windows.Forms.ComboBox()
        Me.GPSDataTabControl.SuspendLayout()
        Me.GPSDataTabPage.SuspendLayout()
        Me.GPSDataTableLayoutPanel.SuspendLayout()
        Me.GGAGroupBox.SuspendLayout()
        Me.GGATableLayoutPanel.SuspendLayout()
        Me.GLLGroupBox.SuspendLayout()
        Me.GLLTableLayoutPanel.SuspendLayout()
        Me.MainTableLayoutPanel.SuspendLayout()
        Me.SetComPortGroupBox.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.ConfigPortTableLayoutPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'GPSDataTabControl
        '
        Me.MainTableLayoutPanel.SetColumnSpan(Me.GPSDataTabControl, 2)
        Me.GPSDataTabControl.Controls.Add(Me.GPSDataTabPage)
        Me.GPSDataTabControl.Controls.Add(Me.MapTabPage)
        Me.GPSDataTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GPSDataTabControl.Location = New System.Drawing.Point(3, 129)
        Me.GPSDataTabControl.Name = "GPSDataTabControl"
        Me.GPSDataTabControl.SelectedIndex = 0
        Me.GPSDataTabControl.Size = New System.Drawing.Size(840, 368)
        Me.GPSDataTabControl.TabIndex = 0
        '
        'GPSDataTabPage
        '
        Me.GPSDataTabPage.Controls.Add(Me.GPSDataTableLayoutPanel)
        Me.GPSDataTabPage.Location = New System.Drawing.Point(4, 22)
        Me.GPSDataTabPage.Name = "GPSDataTabPage"
        Me.GPSDataTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.GPSDataTabPage.Size = New System.Drawing.Size(832, 342)
        Me.GPSDataTabPage.TabIndex = 0
        Me.GPSDataTabPage.Text = "GPS Data"
        Me.GPSDataTabPage.UseVisualStyleBackColor = True
        '
        'GPSDataTableLayoutPanel
        '
        Me.GPSDataTableLayoutPanel.ColumnCount = 3
        Me.GPSDataTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.GPSDataTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.GPSDataTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.GPSDataTableLayoutPanel.Controls.Add(Me.GGAGroupBox, 0, 0)
        Me.GPSDataTableLayoutPanel.Controls.Add(Me.GPSRawDataLabel, 0, 3)
        Me.GPSDataTableLayoutPanel.Controls.Add(Me.GLLGroupBox, 1, 0)
        Me.GPSDataTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GPSDataTableLayoutPanel.Location = New System.Drawing.Point(3, 3)
        Me.GPSDataTableLayoutPanel.Name = "GPSDataTableLayoutPanel"
        Me.GPSDataTableLayoutPanel.RowCount = 1
        Me.GPSDataTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.33333!))
        Me.GPSDataTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.GPSDataTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.GPSDataTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.GPSDataTableLayoutPanel.Size = New System.Drawing.Size(826, 336)
        Me.GPSDataTableLayoutPanel.TabIndex = 0
        '
        'GGAGroupBox
        '
        Me.GGAGroupBox.Controls.Add(Me.GGATableLayoutPanel)
        Me.GGAGroupBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GGAGroupBox.Location = New System.Drawing.Point(3, 3)
        Me.GGAGroupBox.Name = "GGAGroupBox"
        Me.GGAGroupBox.Size = New System.Drawing.Size(361, 273)
        Me.GGAGroupBox.TabIndex = 4
        Me.GGAGroupBox.TabStop = False
        Me.GGAGroupBox.Text = "GGA - Global Positioning System Fixed Data"
        '
        'GGATableLayoutPanel
        '
        Me.GGATableLayoutPanel.ColumnCount = 2
        Me.GGATableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.GGATableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.GGATableLayoutPanel.Controls.Add(Me.GGAUTCTimeTitleLabel, 0, 0)
        Me.GGATableLayoutPanel.Controls.Add(Me.GGAUTCTimeValueLabel, 1, 0)
        Me.GGATableLayoutPanel.Controls.Add(Me.GGALatitudeTitleLabel, 0, 1)
        Me.GGATableLayoutPanel.Controls.Add(Me.GGALatitudeValueLabel, 1, 1)
        Me.GGATableLayoutPanel.Controls.Add(Me.GGALogitudeTitleLabel, 0, 2)
        Me.GGATableLayoutPanel.Controls.Add(Me.GGALogitudeValueLabel, 1, 2)
        Me.GGATableLayoutPanel.Controls.Add(Me.GGAPosFixTitleLabel, 0, 3)
        Me.GGATableLayoutPanel.Controls.Add(Me.GGAPosFixValueLabel, 1, 3)
        Me.GGATableLayoutPanel.Controls.Add(Me.GGASatellitesUsedTitleLabel, 0, 4)
        Me.GGATableLayoutPanel.Controls.Add(Me.GGASatellitesUsedValueLabel, 1, 4)
        Me.GGATableLayoutPanel.Controls.Add(Me.GGAHDOPTitleLabel, 0, 5)
        Me.GGATableLayoutPanel.Controls.Add(Me.GGAHDOPValueLabel, 1, 5)
        Me.GGATableLayoutPanel.Controls.Add(Me.GGAMSLAltitudeTitleLabel, 0, 6)
        Me.GGATableLayoutPanel.Controls.Add(Me.GGAMSLAltitudeValueLabel, 1, 6)
        Me.GGATableLayoutPanel.Controls.Add(Me.GGAGeoindSepTitleLabel, 0, 7)
        Me.GGATableLayoutPanel.Controls.Add(Me.GGAGeoindSepValueLabel, 1, 7)
        Me.GGATableLayoutPanel.Controls.Add(Me.GGAElipsoidAltitudeTitleLabel, 0, 8)
        Me.GGATableLayoutPanel.Controls.Add(Me.GGAElipsoidAltitudeValueLabel, 1, 8)
        Me.GGATableLayoutPanel.Controls.Add(Me.GGAAgeDiffCorrTitleLabel, 0, 9)
        Me.GGATableLayoutPanel.Controls.Add(Me.GGAAgeDiffCorrValueLabel, 1, 9)
        Me.GGATableLayoutPanel.Controls.Add(Me.GGADiffRefStationIDTitleLabel, 0, 10)
        Me.GGATableLayoutPanel.Controls.Add(Me.GGADiffRefStationIDValueLabel, 1, 10)
        Me.GGATableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GGATableLayoutPanel.Location = New System.Drawing.Point(3, 16)
        Me.GGATableLayoutPanel.Name = "GGATableLayoutPanel"
        Me.GGATableLayoutPanel.RowCount = 12
        Me.GGATableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.GGATableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.GGATableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.GGATableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.GGATableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.GGATableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.GGATableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.GGATableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.GGATableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.GGATableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.GGATableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.GGATableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.GGATableLayoutPanel.Size = New System.Drawing.Size(355, 254)
        Me.GGATableLayoutPanel.TabIndex = 0
        '
        'GGAUTCTimeTitleLabel
        '
        Me.GGAUTCTimeTitleLabel.AutoSize = True
        Me.GGAUTCTimeTitleLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GGAUTCTimeTitleLabel.Location = New System.Drawing.Point(3, 0)
        Me.GGAUTCTimeTitleLabel.Name = "GGAUTCTimeTitleLabel"
        Me.GGAUTCTimeTitleLabel.Size = New System.Drawing.Size(99, 20)
        Me.GGAUTCTimeTitleLabel.TabIndex = 2
        Me.GGAUTCTimeTitleLabel.Text = "UTC Time"
        Me.GGAUTCTimeTitleLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'GGAUTCTimeValueLabel
        '
        Me.GGAUTCTimeValueLabel.AutoSize = True
        Me.GGAUTCTimeValueLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GGAUTCTimeValueLabel.Location = New System.Drawing.Point(108, 0)
        Me.GGAUTCTimeValueLabel.Name = "GGAUTCTimeValueLabel"
        Me.GGAUTCTimeValueLabel.Size = New System.Drawing.Size(244, 20)
        Me.GGAUTCTimeValueLabel.TabIndex = 3
        Me.GGAUTCTimeValueLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'GGALatitudeTitleLabel
        '
        Me.GGALatitudeTitleLabel.AutoSize = True
        Me.GGALatitudeTitleLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GGALatitudeTitleLabel.Location = New System.Drawing.Point(3, 20)
        Me.GGALatitudeTitleLabel.Name = "GGALatitudeTitleLabel"
        Me.GGALatitudeTitleLabel.Size = New System.Drawing.Size(99, 20)
        Me.GGALatitudeTitleLabel.TabIndex = 0
        Me.GGALatitudeTitleLabel.Text = "Latitude"
        Me.GGALatitudeTitleLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'GGALatitudeValueLabel
        '
        Me.GGALatitudeValueLabel.AutoSize = True
        Me.GGALatitudeValueLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GGALatitudeValueLabel.Location = New System.Drawing.Point(108, 20)
        Me.GGALatitudeValueLabel.Name = "GGALatitudeValueLabel"
        Me.GGALatitudeValueLabel.Size = New System.Drawing.Size(244, 20)
        Me.GGALatitudeValueLabel.TabIndex = 4
        Me.GGALatitudeValueLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'GGALogitudeTitleLabel
        '
        Me.GGALogitudeTitleLabel.AutoSize = True
        Me.GGALogitudeTitleLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GGALogitudeTitleLabel.Location = New System.Drawing.Point(3, 40)
        Me.GGALogitudeTitleLabel.Name = "GGALogitudeTitleLabel"
        Me.GGALogitudeTitleLabel.Size = New System.Drawing.Size(99, 20)
        Me.GGALogitudeTitleLabel.TabIndex = 5
        Me.GGALogitudeTitleLabel.Text = "Longitude"
        Me.GGALogitudeTitleLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'GGALogitudeValueLabel
        '
        Me.GGALogitudeValueLabel.AutoSize = True
        Me.GGALogitudeValueLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GGALogitudeValueLabel.Location = New System.Drawing.Point(108, 40)
        Me.GGALogitudeValueLabel.Name = "GGALogitudeValueLabel"
        Me.GGALogitudeValueLabel.Size = New System.Drawing.Size(244, 20)
        Me.GGALogitudeValueLabel.TabIndex = 6
        Me.GGALogitudeValueLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'GGAPosFixTitleLabel
        '
        Me.GGAPosFixTitleLabel.AutoSize = True
        Me.GGAPosFixTitleLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GGAPosFixTitleLabel.Location = New System.Drawing.Point(3, 60)
        Me.GGAPosFixTitleLabel.Name = "GGAPosFixTitleLabel"
        Me.GGAPosFixTitleLabel.Size = New System.Drawing.Size(99, 20)
        Me.GGAPosFixTitleLabel.TabIndex = 8
        Me.GGAPosFixTitleLabel.Text = "Posistion Fix?"
        Me.GGAPosFixTitleLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'GGAPosFixValueLabel
        '
        Me.GGAPosFixValueLabel.AutoSize = True
        Me.GGAPosFixValueLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GGAPosFixValueLabel.Location = New System.Drawing.Point(108, 60)
        Me.GGAPosFixValueLabel.Name = "GGAPosFixValueLabel"
        Me.GGAPosFixValueLabel.Size = New System.Drawing.Size(244, 20)
        Me.GGAPosFixValueLabel.TabIndex = 9
        Me.GGAPosFixValueLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'GGASatellitesUsedTitleLabel
        '
        Me.GGASatellitesUsedTitleLabel.AutoSize = True
        Me.GGASatellitesUsedTitleLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GGASatellitesUsedTitleLabel.Location = New System.Drawing.Point(3, 80)
        Me.GGASatellitesUsedTitleLabel.Name = "GGASatellitesUsedTitleLabel"
        Me.GGASatellitesUsedTitleLabel.Size = New System.Drawing.Size(99, 20)
        Me.GGASatellitesUsedTitleLabel.TabIndex = 10
        Me.GGASatellitesUsedTitleLabel.Text = "Satellites Used"
        Me.GGASatellitesUsedTitleLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'GGASatellitesUsedValueLabel
        '
        Me.GGASatellitesUsedValueLabel.AutoSize = True
        Me.GGASatellitesUsedValueLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GGASatellitesUsedValueLabel.Location = New System.Drawing.Point(108, 80)
        Me.GGASatellitesUsedValueLabel.Name = "GGASatellitesUsedValueLabel"
        Me.GGASatellitesUsedValueLabel.Size = New System.Drawing.Size(244, 20)
        Me.GGASatellitesUsedValueLabel.TabIndex = 11
        Me.GGASatellitesUsedValueLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'GGAHDOPTitleLabel
        '
        Me.GGAHDOPTitleLabel.AutoSize = True
        Me.GGAHDOPTitleLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GGAHDOPTitleLabel.Location = New System.Drawing.Point(3, 100)
        Me.GGAHDOPTitleLabel.Name = "GGAHDOPTitleLabel"
        Me.GGAHDOPTitleLabel.Size = New System.Drawing.Size(99, 20)
        Me.GGAHDOPTitleLabel.TabIndex = 12
        Me.GGAHDOPTitleLabel.Text = "HDOP Precision"
        Me.GGAHDOPTitleLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'GGAHDOPValueLabel
        '
        Me.GGAHDOPValueLabel.AutoSize = True
        Me.GGAHDOPValueLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GGAHDOPValueLabel.Location = New System.Drawing.Point(108, 100)
        Me.GGAHDOPValueLabel.Name = "GGAHDOPValueLabel"
        Me.GGAHDOPValueLabel.Size = New System.Drawing.Size(244, 20)
        Me.GGAHDOPValueLabel.TabIndex = 13
        Me.GGAHDOPValueLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'GGAMSLAltitudeTitleLabel
        '
        Me.GGAMSLAltitudeTitleLabel.AutoSize = True
        Me.GGAMSLAltitudeTitleLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GGAMSLAltitudeTitleLabel.Location = New System.Drawing.Point(3, 120)
        Me.GGAMSLAltitudeTitleLabel.Name = "GGAMSLAltitudeTitleLabel"
        Me.GGAMSLAltitudeTitleLabel.Size = New System.Drawing.Size(99, 20)
        Me.GGAMSLAltitudeTitleLabel.TabIndex = 14
        Me.GGAMSLAltitudeTitleLabel.Text = "MSL Altitude"
        Me.GGAMSLAltitudeTitleLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'GGAMSLAltitudeValueLabel
        '
        Me.GGAMSLAltitudeValueLabel.AutoSize = True
        Me.GGAMSLAltitudeValueLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GGAMSLAltitudeValueLabel.Location = New System.Drawing.Point(108, 120)
        Me.GGAMSLAltitudeValueLabel.Name = "GGAMSLAltitudeValueLabel"
        Me.GGAMSLAltitudeValueLabel.Size = New System.Drawing.Size(244, 20)
        Me.GGAMSLAltitudeValueLabel.TabIndex = 15
        Me.GGAMSLAltitudeValueLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'GGAGeoindSepTitleLabel
        '
        Me.GGAGeoindSepTitleLabel.AutoSize = True
        Me.GGAGeoindSepTitleLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GGAGeoindSepTitleLabel.Location = New System.Drawing.Point(3, 140)
        Me.GGAGeoindSepTitleLabel.Name = "GGAGeoindSepTitleLabel"
        Me.GGAGeoindSepTitleLabel.Size = New System.Drawing.Size(99, 20)
        Me.GGAGeoindSepTitleLabel.TabIndex = 16
        Me.GGAGeoindSepTitleLabel.Text = "Geoid Separation"
        Me.GGAGeoindSepTitleLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'GGAGeoindSepValueLabel
        '
        Me.GGAGeoindSepValueLabel.AutoSize = True
        Me.GGAGeoindSepValueLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GGAGeoindSepValueLabel.Location = New System.Drawing.Point(108, 140)
        Me.GGAGeoindSepValueLabel.Name = "GGAGeoindSepValueLabel"
        Me.GGAGeoindSepValueLabel.Size = New System.Drawing.Size(244, 20)
        Me.GGAGeoindSepValueLabel.TabIndex = 17
        Me.GGAGeoindSepValueLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'GGAElipsoidAltitudeTitleLabel
        '
        Me.GGAElipsoidAltitudeTitleLabel.AutoSize = True
        Me.GGAElipsoidAltitudeTitleLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GGAElipsoidAltitudeTitleLabel.Location = New System.Drawing.Point(3, 160)
        Me.GGAElipsoidAltitudeTitleLabel.Name = "GGAElipsoidAltitudeTitleLabel"
        Me.GGAElipsoidAltitudeTitleLabel.Size = New System.Drawing.Size(99, 20)
        Me.GGAElipsoidAltitudeTitleLabel.TabIndex = 18
        Me.GGAElipsoidAltitudeTitleLabel.Text = "Ellipsoid Altitude"
        Me.GGAElipsoidAltitudeTitleLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'GGAElipsoidAltitudeValueLabel
        '
        Me.GGAElipsoidAltitudeValueLabel.AutoSize = True
        Me.GGAElipsoidAltitudeValueLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GGAElipsoidAltitudeValueLabel.Location = New System.Drawing.Point(108, 160)
        Me.GGAElipsoidAltitudeValueLabel.Name = "GGAElipsoidAltitudeValueLabel"
        Me.GGAElipsoidAltitudeValueLabel.Size = New System.Drawing.Size(244, 20)
        Me.GGAElipsoidAltitudeValueLabel.TabIndex = 19
        Me.GGAElipsoidAltitudeValueLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'GGAAgeDiffCorrTitleLabel
        '
        Me.GGAAgeDiffCorrTitleLabel.AutoSize = True
        Me.GGAAgeDiffCorrTitleLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GGAAgeDiffCorrTitleLabel.Location = New System.Drawing.Point(3, 180)
        Me.GGAAgeDiffCorrTitleLabel.Name = "GGAAgeDiffCorrTitleLabel"
        Me.GGAAgeDiffCorrTitleLabel.Size = New System.Drawing.Size(99, 20)
        Me.GGAAgeDiffCorrTitleLabel.TabIndex = 20
        Me.GGAAgeDiffCorrTitleLabel.Text = "Age of Diff. Corr."
        Me.GGAAgeDiffCorrTitleLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'GGAAgeDiffCorrValueLabel
        '
        Me.GGAAgeDiffCorrValueLabel.AutoSize = True
        Me.GGAAgeDiffCorrValueLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GGAAgeDiffCorrValueLabel.Location = New System.Drawing.Point(108, 180)
        Me.GGAAgeDiffCorrValueLabel.Name = "GGAAgeDiffCorrValueLabel"
        Me.GGAAgeDiffCorrValueLabel.Size = New System.Drawing.Size(244, 20)
        Me.GGAAgeDiffCorrValueLabel.TabIndex = 21
        Me.GGAAgeDiffCorrValueLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'GGADiffRefStationIDTitleLabel
        '
        Me.GGADiffRefStationIDTitleLabel.AutoSize = True
        Me.GGADiffRefStationIDTitleLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GGADiffRefStationIDTitleLabel.Location = New System.Drawing.Point(3, 200)
        Me.GGADiffRefStationIDTitleLabel.Name = "GGADiffRefStationIDTitleLabel"
        Me.GGADiffRefStationIDTitleLabel.Size = New System.Drawing.Size(99, 20)
        Me.GGADiffRefStationIDTitleLabel.TabIndex = 22
        Me.GGADiffRefStationIDTitleLabel.Text = "Diff. Ref. Station ID"
        Me.GGADiffRefStationIDTitleLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'GGADiffRefStationIDValueLabel
        '
        Me.GGADiffRefStationIDValueLabel.AutoSize = True
        Me.GGADiffRefStationIDValueLabel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GGADiffRefStationIDValueLabel.Location = New System.Drawing.Point(108, 207)
        Me.GGADiffRefStationIDValueLabel.Name = "GGADiffRefStationIDValueLabel"
        Me.GGADiffRefStationIDValueLabel.Size = New System.Drawing.Size(244, 13)
        Me.GGADiffRefStationIDValueLabel.TabIndex = 23
        Me.GGADiffRefStationIDValueLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'GPSRawDataLabel
        '
        Me.GPSRawDataLabel.AutoSize = True
        Me.GPSDataTableLayoutPanel.SetColumnSpan(Me.GPSRawDataLabel, 2)
        Me.GPSRawDataLabel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GPSRawDataLabel.Location = New System.Drawing.Point(3, 323)
        Me.GPSRawDataLabel.Name = "GPSRawDataLabel"
        Me.GPSRawDataLabel.Size = New System.Drawing.Size(728, 13)
        Me.GPSRawDataLabel.TabIndex = 6
        Me.GPSRawDataLabel.Tag = ""
        '
        'GLLGroupBox
        '
        Me.GLLGroupBox.Controls.Add(Me.GLLTableLayoutPanel)
        Me.GLLGroupBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GLLGroupBox.Location = New System.Drawing.Point(370, 3)
        Me.GLLGroupBox.Name = "GLLGroupBox"
        Me.GLLGroupBox.Size = New System.Drawing.Size(361, 273)
        Me.GLLGroupBox.TabIndex = 7
        Me.GLLGroupBox.TabStop = False
        Me.GLLGroupBox.Text = "GLL"
        '
        'GLLTableLayoutPanel
        '
        Me.GLLTableLayoutPanel.ColumnCount = 2
        Me.GLLTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.GLLTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.GLLTableLayoutPanel.Controls.Add(Me.GLLDescriptionLabel, 0, 0)
        Me.GLLTableLayoutPanel.Controls.Add(Me.GLLUTCTimeTitleLabel, 0, 1)
        Me.GLLTableLayoutPanel.Controls.Add(Me.GLLUTCTimeValueLabel, 1, 1)
        Me.GLLTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GLLTableLayoutPanel.Location = New System.Drawing.Point(3, 16)
        Me.GLLTableLayoutPanel.Name = "GLLTableLayoutPanel"
        Me.GLLTableLayoutPanel.RowCount = 4
        Me.GLLTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.GLLTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.GLLTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.GLLTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.GLLTableLayoutPanel.Size = New System.Drawing.Size(355, 254)
        Me.GLLTableLayoutPanel.TabIndex = 0
        '
        'GLLDescriptionLabel
        '
        Me.GLLDescriptionLabel.AutoSize = True
        Me.GLLTableLayoutPanel.SetColumnSpan(Me.GLLDescriptionLabel, 2)
        Me.GLLDescriptionLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GLLDescriptionLabel.Location = New System.Drawing.Point(3, 0)
        Me.GLLDescriptionLabel.Name = "GLLDescriptionLabel"
        Me.GLLDescriptionLabel.Size = New System.Drawing.Size(349, 20)
        Me.GLLDescriptionLabel.TabIndex = 0
        Me.GLLDescriptionLabel.Text = "GLL - Geographic Position - Latitude/Longitude"
        '
        'GLLUTCTimeTitleLabel
        '
        Me.GLLUTCTimeTitleLabel.AutoSize = True
        Me.GLLUTCTimeTitleLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GLLUTCTimeTitleLabel.Location = New System.Drawing.Point(3, 20)
        Me.GLLUTCTimeTitleLabel.Name = "GLLUTCTimeTitleLabel"
        Me.GLLUTCTimeTitleLabel.Size = New System.Drawing.Size(171, 20)
        Me.GLLUTCTimeTitleLabel.TabIndex = 1
        Me.GLLUTCTimeTitleLabel.Text = "UTC Time"
        Me.GLLUTCTimeTitleLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GLLUTCTimeValueLabel
        '
        Me.GLLUTCTimeValueLabel.AutoSize = True
        Me.GLLUTCTimeValueLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GLLUTCTimeValueLabel.Location = New System.Drawing.Point(180, 20)
        Me.GLLUTCTimeValueLabel.Name = "GLLUTCTimeValueLabel"
        Me.GLLUTCTimeValueLabel.Size = New System.Drawing.Size(172, 20)
        Me.GLLUTCTimeValueLabel.TabIndex = 2
        '
        'MapTabPage
        '
        Me.MapTabPage.Location = New System.Drawing.Point(4, 22)
        Me.MapTabPage.Name = "MapTabPage"
        Me.MapTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.MapTabPage.Size = New System.Drawing.Size(832, 342)
        Me.MapTabPage.TabIndex = 1
        Me.MapTabPage.Text = "Map"
        Me.MapTabPage.UseVisualStyleBackColor = True
        '
        'stopButton
        '
        Me.stopButton.Location = New System.Drawing.Point(747, 3)
        Me.stopButton.Name = "stopButton"
        Me.stopButton.Size = New System.Drawing.Size(75, 51)
        Me.stopButton.TabIndex = 1
        Me.stopButton.Text = "Stop"
        Me.stopButton.UseVisualStyleBackColor = True
        '
        'StartButton
        '
        Me.StartButton.Location = New System.Drawing.Point(666, 3)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(75, 51)
        Me.StartButton.TabIndex = 0
        Me.StartButton.Text = "Start"
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'getGPSDataTimer
        '
        Me.getGPSDataTimer.Interval = 500
        '
        'MainTableLayoutPanel
        '
        Me.MainTableLayoutPanel.ColumnCount = 2
        Me.MainTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.MainTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.MainTableLayoutPanel.Controls.Add(Me.GPSDataTabControl, 0, 2)
        Me.MainTableLayoutPanel.Controls.Add(Me.ButtonsFlowLayoutPanel, 1, 1)
        Me.MainTableLayoutPanel.Controls.Add(Me.SetComPortGroupBox, 0, 0)
        Me.MainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainTableLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.MainTableLayoutPanel.Name = "MainTableLayoutPanel"
        Me.MainTableLayoutPanel.RowCount = 4
        Me.MainTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.MainTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25!))
        Me.MainTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.5!))
        Me.MainTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25!))
        Me.MainTableLayoutPanel.Size = New System.Drawing.Size(846, 528)
        Me.MainTableLayoutPanel.TabIndex = 1
        '
        'ButtonsFlowLayoutPanel
        '
        Me.ButtonsFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonsFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.ButtonsFlowLayoutPanel.Location = New System.Drawing.Point(426, 103)
        Me.ButtonsFlowLayoutPanel.Name = "ButtonsFlowLayoutPanel"
        Me.ButtonsFlowLayoutPanel.Size = New System.Drawing.Size(417, 20)
        Me.ButtonsFlowLayoutPanel.TabIndex = 1
        '
        'SetComPortGroupBox
        '
        Me.MainTableLayoutPanel.SetColumnSpan(Me.SetComPortGroupBox, 2)
        Me.SetComPortGroupBox.Controls.Add(Me.FlowLayoutPanel2)
        Me.SetComPortGroupBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SetComPortGroupBox.Location = New System.Drawing.Point(3, 3)
        Me.SetComPortGroupBox.Name = "SetComPortGroupBox"
        Me.SetComPortGroupBox.Size = New System.Drawing.Size(840, 94)
        Me.SetComPortGroupBox.TabIndex = 2
        Me.SetComPortGroupBox.TabStop = False
        Me.SetComPortGroupBox.Text = "Com Port Settings"
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.ConfigPortTableLayoutPanel)
        Me.FlowLayoutPanel2.Controls.Add(Me.StartButton)
        Me.FlowLayoutPanel2.Controls.Add(Me.stopButton)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(3, 16)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(834, 75)
        Me.FlowLayoutPanel2.TabIndex = 0
        '
        'ConfigPortTableLayoutPanel
        '
        Me.ConfigPortTableLayoutPanel.ColumnCount = 5
        Me.ConfigPortTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.ConfigPortTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.ConfigPortTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.ConfigPortTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.ConfigPortTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.ConfigPortTableLayoutPanel.Controls.Add(Me.ComPortComboBox, 0, 1)
        Me.ConfigPortTableLayoutPanel.Controls.Add(Me.ComPortLabel, 0, 0)
        Me.ConfigPortTableLayoutPanel.Controls.Add(Me.ComPortBaudRateLabel, 1, 0)
        Me.ConfigPortTableLayoutPanel.Controls.Add(Me.ComPortBaudRateComboBox, 1, 1)
        Me.ConfigPortTableLayoutPanel.Controls.Add(Me.ComPortParityLabel, 2, 0)
        Me.ConfigPortTableLayoutPanel.Controls.Add(Me.ComPortParityComboBox, 2, 1)
        Me.ConfigPortTableLayoutPanel.Controls.Add(Me.ComPortDataBitsLabel, 3, 0)
        Me.ConfigPortTableLayoutPanel.Controls.Add(Me.ComPortDataBitsComboBox, 3, 1)
        Me.ConfigPortTableLayoutPanel.Controls.Add(Me.ComPortStopBitsLabel, 4, 0)
        Me.ConfigPortTableLayoutPanel.Controls.Add(Me.ComPortStopBitsComboBox, 4, 1)
        Me.ConfigPortTableLayoutPanel.Location = New System.Drawing.Point(3, 3)
        Me.ConfigPortTableLayoutPanel.Name = "ConfigPortTableLayoutPanel"
        Me.ConfigPortTableLayoutPanel.RowCount = 2
        Me.ConfigPortTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.18518!))
        Me.ConfigPortTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.81481!))
        Me.ConfigPortTableLayoutPanel.Size = New System.Drawing.Size(657, 51)
        Me.ConfigPortTableLayoutPanel.TabIndex = 0
        '
        'ComPortComboBox
        '
        Me.ComPortComboBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComPortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComPortComboBox.FormattingEnabled = True
        Me.ComPortComboBox.Location = New System.Drawing.Point(3, 20)
        Me.ComPortComboBox.Name = "ComPortComboBox"
        Me.ComPortComboBox.Size = New System.Drawing.Size(125, 21)
        Me.ComPortComboBox.TabIndex = 0
        '
        'ComPortLabel
        '
        Me.ComPortLabel.AutoSize = True
        Me.ComPortLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComPortLabel.Location = New System.Drawing.Point(3, 0)
        Me.ComPortLabel.Name = "ComPortLabel"
        Me.ComPortLabel.Size = New System.Drawing.Size(125, 17)
        Me.ComPortLabel.TabIndex = 1
        Me.ComPortLabel.Text = "COM Port"
        Me.ComPortLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ComPortBaudRateLabel
        '
        Me.ComPortBaudRateLabel.AutoSize = True
        Me.ComPortBaudRateLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComPortBaudRateLabel.Location = New System.Drawing.Point(134, 0)
        Me.ComPortBaudRateLabel.Name = "ComPortBaudRateLabel"
        Me.ComPortBaudRateLabel.Size = New System.Drawing.Size(125, 17)
        Me.ComPortBaudRateLabel.TabIndex = 2
        Me.ComPortBaudRateLabel.Text = "Baud Rate"
        Me.ComPortBaudRateLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ComPortBaudRateComboBox
        '
        Me.ComPortBaudRateComboBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComPortBaudRateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComPortBaudRateComboBox.FormattingEnabled = True
        Me.ComPortBaudRateComboBox.Items.AddRange(New Object() {"75", "110", "134", "150", "300", "600", "1200", "1800", "2400", "4800", "7200", "9600", "14400", "19200", "38400", "57600", "115200", "128000"})
        Me.ComPortBaudRateComboBox.Location = New System.Drawing.Point(134, 20)
        Me.ComPortBaudRateComboBox.Name = "ComPortBaudRateComboBox"
        Me.ComPortBaudRateComboBox.Size = New System.Drawing.Size(125, 21)
        Me.ComPortBaudRateComboBox.TabIndex = 3
        '
        'ComPortParityLabel
        '
        Me.ComPortParityLabel.AutoSize = True
        Me.ComPortParityLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComPortParityLabel.Location = New System.Drawing.Point(265, 0)
        Me.ComPortParityLabel.Name = "ComPortParityLabel"
        Me.ComPortParityLabel.Size = New System.Drawing.Size(125, 17)
        Me.ComPortParityLabel.TabIndex = 4
        Me.ComPortParityLabel.Text = "Parity"
        Me.ComPortParityLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ComPortParityComboBox
        '
        Me.ComPortParityComboBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComPortParityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComPortParityComboBox.FormattingEnabled = True
        Me.ComPortParityComboBox.Items.AddRange(New Object() {"Even", "Mark", "None", "Odd", "Space"})
        Me.ComPortParityComboBox.Location = New System.Drawing.Point(265, 20)
        Me.ComPortParityComboBox.Name = "ComPortParityComboBox"
        Me.ComPortParityComboBox.Size = New System.Drawing.Size(125, 21)
        Me.ComPortParityComboBox.TabIndex = 5
        '
        'ComPortDataBitsLabel
        '
        Me.ComPortDataBitsLabel.AutoSize = True
        Me.ComPortDataBitsLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComPortDataBitsLabel.Location = New System.Drawing.Point(396, 0)
        Me.ComPortDataBitsLabel.Name = "ComPortDataBitsLabel"
        Me.ComPortDataBitsLabel.Size = New System.Drawing.Size(125, 17)
        Me.ComPortDataBitsLabel.TabIndex = 6
        Me.ComPortDataBitsLabel.Text = "Data Bits"
        Me.ComPortDataBitsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ComPortDataBitsComboBox
        '
        Me.ComPortDataBitsComboBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComPortDataBitsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComPortDataBitsComboBox.FormattingEnabled = True
        Me.ComPortDataBitsComboBox.Items.AddRange(New Object() {"5", "6", "7", "8"})
        Me.ComPortDataBitsComboBox.Location = New System.Drawing.Point(396, 20)
        Me.ComPortDataBitsComboBox.Name = "ComPortDataBitsComboBox"
        Me.ComPortDataBitsComboBox.Size = New System.Drawing.Size(125, 21)
        Me.ComPortDataBitsComboBox.TabIndex = 7
        '
        'ComPortStopBitsLabel
        '
        Me.ComPortStopBitsLabel.AutoSize = True
        Me.ComPortStopBitsLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComPortStopBitsLabel.Location = New System.Drawing.Point(527, 0)
        Me.ComPortStopBitsLabel.Name = "ComPortStopBitsLabel"
        Me.ComPortStopBitsLabel.Size = New System.Drawing.Size(127, 17)
        Me.ComPortStopBitsLabel.TabIndex = 8
        Me.ComPortStopBitsLabel.Text = "Stop Bits"
        Me.ComPortStopBitsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ComPortStopBitsComboBox
        '
        Me.ComPortStopBitsComboBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComPortStopBitsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComPortStopBitsComboBox.FormattingEnabled = True
        Me.ComPortStopBitsComboBox.Items.AddRange(New Object() {"0", "1", "1.5", "2"})
        Me.ComPortStopBitsComboBox.Location = New System.Drawing.Point(527, 20)
        Me.ComPortStopBitsComboBox.Name = "ComPortStopBitsComboBox"
        Me.ComPortStopBitsComboBox.Size = New System.Drawing.Size(127, 21)
        Me.ComPortStopBitsComboBox.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(846, 528)
        Me.Controls.Add(Me.MainTableLayoutPanel)
        Me.Name = "Form1"
        Me.Text = "GPS Data Show"
        Me.GPSDataTabControl.ResumeLayout(False)
        Me.GPSDataTabPage.ResumeLayout(False)
        Me.GPSDataTableLayoutPanel.ResumeLayout(False)
        Me.GPSDataTableLayoutPanel.PerformLayout()
        Me.GGAGroupBox.ResumeLayout(False)
        Me.GGATableLayoutPanel.ResumeLayout(False)
        Me.GGATableLayoutPanel.PerformLayout()
        Me.GLLGroupBox.ResumeLayout(False)
        Me.GLLTableLayoutPanel.ResumeLayout(False)
        Me.GLLTableLayoutPanel.PerformLayout()
        Me.MainTableLayoutPanel.ResumeLayout(False)
        Me.SetComPortGroupBox.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.ConfigPortTableLayoutPanel.ResumeLayout(False)
        Me.ConfigPortTableLayoutPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GPSDataTabControl As System.Windows.Forms.TabControl
    Friend WithEvents GPSDataTabPage As System.Windows.Forms.TabPage
    Friend WithEvents GPSDataTableLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents MapTabPage As System.Windows.Forms.TabPage
    Friend WithEvents GGALatitudeTitleLabel As System.Windows.Forms.Label
    Friend WithEvents stopButton As System.Windows.Forms.Button
    Friend WithEvents StartButton As System.Windows.Forms.Button
    Friend WithEvents getGPSDataTimer As System.Windows.Forms.Timer
    Friend WithEvents MainTableLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents GGAGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents GGATableLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents GGAUTCTimeTitleLabel As System.Windows.Forms.Label
    Friend WithEvents GGAUTCTimeValueLabel As System.Windows.Forms.Label
    Friend WithEvents GGALatitudeValueLabel As System.Windows.Forms.Label
    Friend WithEvents GGALogitudeTitleLabel As System.Windows.Forms.Label
    Friend WithEvents GGALogitudeValueLabel As System.Windows.Forms.Label
    Friend WithEvents GPSRawDataLabel As System.Windows.Forms.Label
    Friend WithEvents GGAPosFixTitleLabel As System.Windows.Forms.Label
    Friend WithEvents GGAPosFixValueLabel As System.Windows.Forms.Label
    Friend WithEvents GGASatellitesUsedTitleLabel As System.Windows.Forms.Label
    Friend WithEvents GGASatellitesUsedValueLabel As System.Windows.Forms.Label
    Friend WithEvents GGAHDOPTitleLabel As System.Windows.Forms.Label
    Friend WithEvents GGAHDOPValueLabel As System.Windows.Forms.Label
    Friend WithEvents GGAMSLAltitudeTitleLabel As System.Windows.Forms.Label
    Friend WithEvents GGAMSLAltitudeValueLabel As System.Windows.Forms.Label
    Friend WithEvents GGAGeoindSepTitleLabel As System.Windows.Forms.Label
    Friend WithEvents GGAGeoindSepValueLabel As System.Windows.Forms.Label
    Friend WithEvents GGAElipsoidAltitudeTitleLabel As System.Windows.Forms.Label
    Friend WithEvents GGAElipsoidAltitudeValueLabel As System.Windows.Forms.Label
    Friend WithEvents GGAAgeDiffCorrTitleLabel As System.Windows.Forms.Label
    Friend WithEvents GGAAgeDiffCorrValueLabel As System.Windows.Forms.Label
    Friend WithEvents GGADiffRefStationIDTitleLabel As System.Windows.Forms.Label
    Friend WithEvents GGADiffRefStationIDValueLabel As System.Windows.Forms.Label
    Friend WithEvents GLLGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents GLLTableLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents GLLDescriptionLabel As System.Windows.Forms.Label
    Friend WithEvents GLLUTCTimeTitleLabel As System.Windows.Forms.Label
    Friend WithEvents GLLUTCTimeValueLabel As System.Windows.Forms.Label
    Friend WithEvents ButtonsFlowLayoutPanel As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents ComPortComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents ConfigPortTableLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ComPortLabel As System.Windows.Forms.Label
    Friend WithEvents ComPortBaudRateLabel As System.Windows.Forms.Label
    Friend WithEvents ComPortBaudRateComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ComPortParityLabel As System.Windows.Forms.Label
    Friend WithEvents ComPortParityComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ComPortDataBitsLabel As System.Windows.Forms.Label
    Friend WithEvents ComPortDataBitsComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ComPortStopBitsLabel As System.Windows.Forms.Label
    Friend WithEvents ComPortStopBitsComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SetComPortGroupBox As System.Windows.Forms.GroupBox

End Class
