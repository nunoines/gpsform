Imports System.IO.Ports


Public Class Form1
    ' Constants
    Public Const inDebug = True

    ' global vars
    Public comError As Boolean = False

    ' data recived vars
    Dim gpsDataLine As String ' a line of gps data
    Dim gpsDataLineArray As Array
    Dim gpsDataMsgType As String ' type of message received

    ' GGA vars
    Dim GGA_UTC_Time As String
    Dim GGA_Lat As String
    Dim GGA_NS_Indicator As String
    Dim GGA_lon As String
    Dim GGA_EW_Indicator As String
    Dim GGA_PosFix As String ' Position fix indicator (0=invalid, 1=valid, 2=valid diferential, 6=dead)
    Dim GGA_NumSats As String '
    Dim GGA_HDOP As String ' precision
    Dim GGA_MSL_Altitude As String
    Dim GGA_MSL_Unit As String
    Dim GGA_GeoidSep As String
    Dim GGA_GeoidUnit As String
    Dim GGA_ElipsoidAltitude As String
    Dim GGA_AgeDiffCorr As String
    Dim GGA_DiffRefStationId As String
    Dim GGA_CheckSum As String

    ' GLL vars
    Dim GLL_UTC_Time As String
    Dim GLL_Lat As String
    Dim GLL_NS_Indicator As String
    Dim GLL_lon As String
    Dim GLL_EW_Indicator As String
    Dim GLL_Status As String
    Dim GLL_Mode As String

    ' Create a new SerialPort object 
    Dim _serialPort As New SerialPort()

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' initialize values
        Call InitializeValues()
    End Sub

    Private Sub StartButton_Click(sender As System.Object, e As System.EventArgs) Handles StartButton.Click
        If Not _serialPort.IsOpen Then
            Call startGPS()
        End If
        If Not comError Then
            getGPSDataTimer.Enabled = True
            StartButton.Enabled = False
            stopButton.Enabled = True
        Else
            getGPSDataTimer.Enabled = False
            StartButton.Enabled = True
            stopButton.Enabled = False
            comError = False
        End If
    End Sub

    Private Sub stopButton_Click(sender As System.Object, e As System.EventArgs) Handles stopButton.Click
        getGPSDataTimer.Enabled = False
        Call stopGPS()
        StartButton.Enabled = True
        stopButton.Enabled = False
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles getGPSDataTimer.Tick
        If _serialPort.IsOpen Then
            Call getGPSData()
        End If
    End Sub


    ' /////////////////////////// 

    Private Sub getGPSData()
        gpsDataLine = _serialPort.ReadLine()
        gpsDataLineArray = Split(gpsDataLine, ",")
        gpsDataMsgType = gpsDataLineArray(0)

        Me.GPSRawDataLabel.Text = gpsDataLine

        Select Case gpsDataMsgType
            Case "$GPGGA" ' GGA protocol header
                GGA_UTC_Time = gpsDataLineArray(1) 'Format(gpsDataLineArray(1), "t")
                GGA_Lat = gpsDataLineArray(2)
                GGA_NS_Indicator = gpsDataLineArray(3)
                GGA_lon = gpsDataLineArray(4)
                GGA_EW_Indicator = gpsDataLineArray(5)
                GGA_PosFix = gpsDataLineArray(6)
                GGA_NumSats = gpsDataLineArray(7)
                GGA_HDOP = gpsDataLineArray(8)
                GGA_MSL_Altitude = gpsDataLineArray(9)
                GGA_MSL_Unit = gpsDataLineArray(10)
                GGA_GeoidSep = gpsDataLineArray(11)
                GGA_GeoidUnit = gpsDataLineArray(12)
                GGA_AgeDiffCorr = gpsDataLineArray(13)
                GGA_DiffRefStationId = gpsDataLineArray(14)

                ' if west, long < 0
                If GGA_EW_Indicator = "W" Then
                    'GGA_lon = GGA_lon * -1
                End If

                ' position fix?
                If GGA_PosFix = 1 Or GGA_PosFix = 2 Then
                    GGA_PosFix = "Valid"
                Else
                    GGA_PosFix = "Invalid"
                End If

                ' elipsoid altitude
                GGA_ElipsoidAltitude = Str(Val(GGA_MSL_Altitude) + Val(GGA_GeoidSep))

                ' atrib to labels
                Me.GGAUTCTimeValueLabel.Text = GGA_UTC_Time
                Me.GGALatitudeValueLabel.Text = GGA_NS_Indicator + " " + GGA_Lat
                Me.GGALogitudeValueLabel.Text = GGA_EW_Indicator + " " + GGA_lon
                Me.GGAPosFixValueLabel.Text = GGA_PosFix
                Me.GGASatellitesUsedValueLabel.Text = GGA_NumSats
                Me.GGAHDOPValueLabel.Text = GGA_HDOP
                Me.GGAMSLAltitudeValueLabel.Text = GGA_MSL_Altitude + " " + GGA_MSL_Unit
                Me.GGAGeoindSepValueLabel.Text = GGA_GeoidSep + " " + GGA_GeoidUnit
                Me.GGAElipsoidAltitudeValueLabel.Text = GGA_ElipsoidAltitude + " " + GGA_MSL_Unit
                Me.GGAAgeDiffCorrValueLabel.Text = IIf(GGA_AgeDiffCorr = "", "-", GGA_AgeDiffCorr)
                Me.GGADiffRefStationIDValueLabel.Text = GGA_DiffRefStationId

            Case "$GPGLL" ' GLL Protocol header
                GLL_Lat = gpsDataLineArray(1)
                GLL_NS_Indicator = gpsDataLineArray(2)
                GLL_lon = gpsDataLineArray(3)
                GLL_EW_Indicator = gpsDataLineArray(4)
                GLL_UTC_Time = gpsDataLineArray(5)
                GLL_Status = gpsDataLineArray(6)
                GLL_Mode = gpsDataLineArray(7)

                Me.GLLUTCTimeValueLabel.Text = GLL_UTC_Time
            Case Else

        End Select
    End Sub

    ' initialize com port with values from form
    Private Sub InitializeComPort()
        ' port name
        _serialPort.PortName = Me.ComPortComboBox.SelectedItem.ToString

        ' baud rate
        _serialPort.BaudRate = Val(Me.ComPortBaudRateComboBox.SelectedItem.ToString)

        ' parity
        '_serialPort.Parity = CType([Enum].Parse(GetType(Parity),
        '                                       Me.ComPortParityComboBox.SelectedItem.ToString(),
        '                                        True), Parity)
        Select Me.ComPortParityComboBox.SelectedItem.ToString()
            Case "None"
                _serialPort.Parity = Parity.None
            Case "Odd"
                _serialPort.Parity = Parity.Odd
            Case "Even"
                _serialPort.Parity = Parity.Even
            Case "Mark"
                _serialPort.Parity = Parity.Mark
            Case "Space"
                _serialPort.Parity = Parity.Space
            Case Else
                _serialPort.Parity = Parity.None
        End Select

        ' databits 5-8
        _serialPort.DataBits = Val(Me.ComPortDataBitsComboBox.SelectedItem.ToString)
        
        ' Stopbits
        '        _serialPort.StopBits = CType([Enum].Parse(GetType(StopBits),
        '                                       Me.ComPortStopBitsComboBox.SelectedItem.ToString(),
        '                                        True), StopBits)
        Select Case Me.ComPortStopBitsComboBox.SelectedItem.ToString()
            Case "0"
                _serialPort.StopBits = StopBits.None
            Case "1"
                _serialPort.StopBits = StopBits.One
            Case "1.5"
                _serialPort.StopBits = StopBits.OnePointFive
            Case "2"
                _serialPort.StopBits = StopBits.Two
            Case Else
                _serialPort.StopBits = StopBits.One
        End Select
    End Sub

    ' opens com port
    Private Sub startGPS()
        ' Set the read/write timeouts
        _serialPort.ReadTimeout = 5000
        _serialPort.WriteTimeout = 5000

        Call InitializeComPort()

        Try
            _serialPort.Open()
        Catch ioAu As System.UnauthorizedAccessException
            MsgBox("Error reading from GPS!", MsgBoxStyle.Critical)
            comError = True
        Catch ioEx As System.IO.IOException
            MsgBox("Error reading from GPS!", MsgBoxStyle.Critical)
            comError = True
        End Try

    End Sub

    ' closes com port
    Private Sub stopGPS()
        _serialPort.Close()
    End Sub


    ' initialize values of items in the form
    Private Sub InitializeValues()
        ' inDebug see raw data
        If Not inDebug Then
            GPSRawDataLabel.Visible = False
        Else
            GPSRawDataLabel.Visible = True
        End If

        'stop button starts desabled
        stopButton.Enabled = False

        ' Show all available COM ports.
        For Each sp As String In My.Computer.Ports.SerialPortNames
            Me.ComPortComboBox.Items.Add(sp)
        Next
        Me.ComPortComboBox.SelectedIndex = 0

        ' com port baud rate, selects default to 9600
        For Each br As String In Me.ComPortBaudRateComboBox.Items
            If br = "9600" Then
                Me.ComPortBaudRateComboBox.SelectedItem = br
            End If
        Next

        ' com Port parity, select none as default
        For Each pr As String In Me.ComPortParityComboBox.Items
            If pr = "None" Then
                Me.ComPortParityComboBox.SelectedItem = pr
            End If
        Next

        'com port data bits, select 8 as default
        For Each db As String In Me.ComPortDataBitsComboBox.Items
            If db = "8" Then
                Me.ComPortDataBitsComboBox.SelectedItem = db
            End If
        Next

        'com port stop bits, select 1 as default
        For Each sb As String In Me.ComPortStopBitsComboBox.Items
            If sb = "1" Then
                Me.ComPortStopBitsComboBox.SelectedItem = sb
            End If
        Next
    End Sub
End Class
