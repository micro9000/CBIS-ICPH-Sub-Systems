Public Class PharmacyTransDialogFrm

    Dim TextToPrint As String = ""

    Dim transNo As String = ""
    Dim amount As String = ""

    Private Sub PharmacyTransDialogFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'ReceiptPrint.PrinterSettings.PrinterName = "EPSON TM-T88V Receipt"

        Dim list As New List(Of String)

        With System.Drawing.Printing.PrinterSettings.InstalledPrinters
            For i As Integer = 0 To .Count - 1
                list.Add(System.Drawing.Printing.PrinterSettings.InstalledPrinters.Item(i))
            Next
        End With
        ReceiptPrint.PrinterSettings.PrinterName = list.Item(1)

        transNo = TransactionIDLbl.Text.ToString
        amount = AmountLbl.Text.ToString
    End Sub

    Public Sub PrintHeader()

        TextToPrint = ""

        'Immaculate Concepcion Polyclinic and Hospital
        'send Business Name
        Dim StringToPrint As String = "Immaculate Concepcion"
        Dim LineLen As Integer = StringToPrint.Length
        Dim spcLen1 As New String(" "c, Math.Round((33 - LineLen) / 2)) 'This line is used to center text in the middle of the receipt
        TextToPrint &= spcLen1 & StringToPrint & Environment.NewLine

        'continue Business name
        StringToPrint = "Polyclinic and Hospital"
        LineLen = StringToPrint.Length
        Dim spcLen2 As New String(" "c, Math.Round((33 - LineLen) / 2))
        TextToPrint &= spcLen2 & StringToPrint & Environment.NewLine

        'send address name
        StringToPrint = "Green Village, Concoption Tarlac"
        LineLen = StringToPrint.Length
        Dim spcLen3 As New String(" "c, Math.Round((33 - LineLen) / 2))
        TextToPrint &= spcLen3 & StringToPrint & Environment.NewLine & Environment.NewLine

        'send address name
        StringToPrint = "Pharmacy"
        LineLen = StringToPrint.Length
        Dim spcLen4 As New String(" "c, Math.Round((33 - LineLen) / 2))
        TextToPrint &= spcLen4 & StringToPrint & Environment.NewLine & Environment.NewLine

    End Sub


    Public Sub ItemsToBePrinted()


        TextToPrint &= "Transaction #       PHA-" & transNo & Environment.NewLine
        TextToPrint &= "Amount              ₱ " & amount & Environment.NewLine

        TextToPrint &= Environment.NewLine & "Date  " & Date.Now & Environment.NewLine
        TextToPrint &= Environment.NewLine & "" & Environment.NewLine

        Dim StringToPrint = "******************"
        Dim LineLen = StringToPrint.Length
        Dim spcLen2 As New String(" "c, Math.Round((33 - LineLen) / 2))
        TextToPrint &= spcLen2 & StringToPrint & Environment.NewLine


        StringToPrint = "This is not your official receipt"
        LineLen = StringToPrint.Length
        Dim spcLen4 As New String(" "c, Math.Round((33 - LineLen) / 2))
        TextToPrint &= spcLen4 & StringToPrint & Environment.NewLine


        StringToPrint = "Please pay this to the cashier"
        LineLen = StringToPrint.Length
        Dim spcLen3 As New String(" "c, Math.Round((33 - LineLen) / 2))
        TextToPrint &= spcLen3 & StringToPrint & Environment.NewLine


    End Sub


    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles ReceiptPrint.PrintPage
        Static currentChar As Integer
        Dim textfont As Font = New Font("Courier New", 10, FontStyle.Bold)

        Dim h, w As Integer
        Dim left, top As Integer
        With ReceiptPrint.DefaultPageSettings
            h = 0
            w = 0
            left = 0
            top = 0
        End With


        Dim lines As Integer = CInt(Math.Round(h / 1))
        Dim b As New Rectangle(left, top, w, h)
        Dim format As StringFormat
        format = New StringFormat(StringFormatFlags.LineLimit)
        Dim line, chars As Integer


        e.Graphics.MeasureString(Mid(TextToPrint, currentChar + 1), textfont, New SizeF(w, h), format, chars, line)
        e.Graphics.DrawString(TextToPrint.Substring(currentChar, chars), New Font("Courier New", 10, FontStyle.Bold), Brushes.Black, b, format)


        currentChar = currentChar + chars
        If currentChar < TextToPrint.Length Then
            e.HasMorePages = True
        Else
            e.HasMorePages = False
            currentChar = 0
        End If
    End Sub

    Private Sub OkBtn_Click(sender As System.Object, e As System.EventArgs) Handles OkBtn.Click

        ' Printing receipt
        'PrintHeader()
        'ItemsToBePrinted()
        'Dim printControl = New Printing.StandardPrintController
        'ReceiptPrint.PrintController = printControl
        'Try
        '    ReceiptPrint.Print()
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try

        Me.Close()
    End Sub

    Private Sub PharmacyTransDialogFrm_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        PharmacyFrm.ClearItemsBtn.PerformClick()
    End Sub


End Class