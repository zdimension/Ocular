Imports System.Drawing.Drawing2D
Imports System.Drawing
Imports System.ComponentModel
<ToolboxBitmap(GetType(OcButton), "OcButtonIcon.bmp")> Public Class OcButton
    Dim ButtonT As String
    Dim ForceCase As Boolean = True
    <Description("Sets the text of the OcButton.")> Property ButtonText() As String
        Get
            If ButtonT = "" Then
                ButtonT = ""
            Else
                Return ButtonT
            End If
        End Get
        Set(ByVal value As String)
            If ForceUppercase = True Then
                value = value.ToUpper
            End If
            ButtonT = value
            Invalidate()
        End Set
    End Property

    <Description("Defines whether or not the button text is automatically made uppercase.")> Property ForceUppercase() As Boolean
        Get
            Return ForceCase
        End Get
        Set(ByVal value As Boolean)
            ForceCase = value
        End Set
    End Property

    Public Sub New()
        InitializeComponent()
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Try
            Dim G As New LinearGradientBrush(New Rectangle(New Point(0, 0), Size), Color.WhiteSmoke, Color.White, 270)
            CreateGraphics.FillRectangle(G, ClientRectangle)
            CreateGraphics.DrawLine(Pens.Silver, 0, 0, Width, 0)
            CreateGraphics.DrawLine(Pens.Silver, 0, Height - 1, Width, Height - 1)
            CreateGraphics.DrawLine(Pens.Silver, 0, 0, 0, Height)
            CreateGraphics.DrawLine(Pens.Silver, Width - 1, 0, Width - 1, Height)
            Dim TextPen As New SolidBrush(ForeColor)
            Dim stringFormat As New StringFormat() With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center}
            Dim R As New Rectangle(New Point(0, 0), ClientRectangle.Size)
            CreateGraphics.DrawString(ButtonT, Font, TextPen, R, stringFormat)
        Catch ex As Exception
            Debug.Print(ex.Message)
        End Try
    End Sub

    Private Sub OcButton_Click(sender As Object, e As EventArgs) Handles Me.Click
        'Dim TMR As New Timer With {.Interval = 1, .Enabled = True}
        'Transitions.Transition.run(Me, "BackColor", Color.LimeGreen, New Transitions.TransitionType_EaseInEaseOut(2000))
        'AddHandler TMR.Tick, Sub()
        '                         Dim G As New LinearGradientBrush(New Rectangle(New Point(0, 0), Size), BackColor, Color.White, 270)
        '                         CreateGraphics.FillRectangle(G, ClientRectangle)
        '                     End Sub
    End Sub

    Private Sub OcButton_Load(sender As Object, e As EventArgs) Handles Me.Load
        CreateGraphics.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias
        CreateGraphics.InterpolationMode = InterpolationMode.HighQualityBicubic
        CreateGraphics.SmoothingMode = SmoothingMode.AntiAlias
    End Sub

    Private Sub OcButton_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        Try
            Dim G As New LinearGradientBrush(New Rectangle(New Point(0, 0), Size), Color.LimeGreen, Color.White, 270)
            CreateGraphics.FillRectangle(G, ClientRectangle)
            CreateGraphics.DrawLine(Pens.Silver, 0, 0, Width, 0)
            CreateGraphics.DrawLine(Pens.Silver, 0, Height - 1, Width, Height - 1)
            CreateGraphics.DrawLine(Pens.Silver, 0, 0, 0, Height)
            CreateGraphics.DrawLine(Pens.Silver, Width - 1, 0, Width - 1, Height)
            Dim TextPen As New SolidBrush(ForeColor)
            Dim stringFormat As New StringFormat() With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center}
            Dim R As New Rectangle(New Point(0, 0), ClientRectangle.Size)
            CreateGraphics.DrawString(ButtonT, Font, TextPen, R, stringFormat)
        Catch ex As Exception
            Debug.Print(ex.Message)
        End Try
    End Sub

    Private Sub OcButton_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter
        Try
            Dim G As New LinearGradientBrush(New Rectangle(New Point(0, 0), Size), Color.LightGreen, Color.White, 270)
            CreateGraphics.FillRectangle(G, ClientRectangle)
            CreateGraphics.DrawLine(Pens.Silver, 0, 0, Width, 0)
            CreateGraphics.DrawLine(Pens.Silver, 0, Height - 1, Width, Height - 1)
            CreateGraphics.DrawLine(Pens.Silver, 0, 0, 0, Height)
            CreateGraphics.DrawLine(Pens.Silver, Width - 1, 0, Width - 1, Height)
            Dim TextPen As New SolidBrush(ForeColor)
            Dim stringFormat As New StringFormat() With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center}
            Dim R As New Rectangle(New Point(0, 0), ClientRectangle.Size)
            CreateGraphics.DrawString(ButtonT, Font, TextPen, R, stringFormat)
        Catch ex As Exception
            Debug.Print(ex.Message)
        End Try
    End Sub

    Private Sub OcButton_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave
        Try
            Dim G As New LinearGradientBrush(New Rectangle(New Point(0, 0), Size), Color.WhiteSmoke, Color.White, 270)
            CreateGraphics.FillRectangle(G, ClientRectangle)
            CreateGraphics.DrawLine(Pens.Silver, 0, 0, Width, 0)
            CreateGraphics.DrawLine(Pens.Silver, 0, Height - 1, Width, Height - 1)
            CreateGraphics.DrawLine(Pens.Silver, 0, 0, 0, Height)
            CreateGraphics.DrawLine(Pens.Silver, Width - 1, 0, Width - 1, Height)
            Dim TextPen As New SolidBrush(ForeColor)
            Dim stringFormat As New StringFormat() With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center}
            Dim R As New Rectangle(New Point(0, 0), ClientRectangle.Size)
            CreateGraphics.DrawString(ButtonT, Font, TextPen, R, stringFormat)
        Catch ex As Exception
            Debug.Print(ex.Message)
        End Try
    End Sub

    Protected Overrides Sub OnResize(e As System.EventArgs)
        MyBase.OnResize(e)
        Me.Invalidate()
    End Sub

    Private Sub OcButton_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        Try
            Dim G As New LinearGradientBrush(New Rectangle(New Point(0, 0), Size), Color.LightGreen, Color.White, 270)
            CreateGraphics.FillRectangle(G, ClientRectangle)
            CreateGraphics.DrawLine(Pens.Silver, 0, 0, Width, 0)
            CreateGraphics.DrawLine(Pens.Silver, 0, Height - 1, Width, Height - 1)
            CreateGraphics.DrawLine(Pens.Silver, 0, 0, 0, Height)
            CreateGraphics.DrawLine(Pens.Silver, Width - 1, 0, Width - 1, Height)
            Dim TextPen As New SolidBrush(ForeColor)
            Dim stringFormat As New StringFormat() With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center}
            Dim R As New Rectangle(New Point(0, 0), ClientRectangle.Size)
            CreateGraphics.DrawString(ButtonT, Font, TextPen, R, stringFormat)
        Catch ex As Exception
            Debug.Print(ex.Message)
        End Try
    End Sub
End Class
