<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Menú
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PanelSuperior = New System.Windows.Forms.Panel()
        Me.PanelLateral = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelForm = New System.Windows.Forms.Panel()
        Me.btnTarea = New System.Windows.Forms.Button()
        Me.btnClase = New System.Windows.Forms.Button()
        Me.btnMaximizar = New System.Windows.Forms.Button()
        Me.btnRestaurar = New System.Windows.Forms.Button()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.PanelSuperior.SuspendLayout()
        Me.PanelLateral.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelSuperior
        '
        Me.PanelSuperior.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PanelSuperior.Controls.Add(Me.btnMaximizar)
        Me.PanelSuperior.Controls.Add(Me.btnRestaurar)
        Me.PanelSuperior.Controls.Add(Me.btnMinimizar)
        Me.PanelSuperior.Controls.Add(Me.btnSalir)
        Me.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSuperior.Location = New System.Drawing.Point(0, 0)
        Me.PanelSuperior.Name = "PanelSuperior"
        Me.PanelSuperior.Size = New System.Drawing.Size(800, 35)
        Me.PanelSuperior.TabIndex = 0
        '
        'PanelLateral
        '
        Me.PanelLateral.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.PanelLateral.Controls.Add(Me.Label1)
        Me.PanelLateral.Controls.Add(Me.Panel2)
        Me.PanelLateral.Controls.Add(Me.btnTarea)
        Me.PanelLateral.Controls.Add(Me.Panel1)
        Me.PanelLateral.Controls.Add(Me.btnClase)
        Me.PanelLateral.Location = New System.Drawing.Point(0, 35)
        Me.PanelLateral.Name = "PanelLateral"
        Me.PanelLateral.Size = New System.Drawing.Size(180, 365)
        Me.PanelLateral.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(54, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 26)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "MENU"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Panel2.Location = New System.Drawing.Point(3, 129)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(10, 42)
        Me.Panel2.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Panel1.Location = New System.Drawing.Point(3, 81)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(10, 42)
        Me.Panel1.TabIndex = 1
        '
        'PanelForm
        '
        Me.PanelForm.BackColor = System.Drawing.SystemColors.Window
        Me.PanelForm.BackgroundImage = Global.IIIParcial.My.Resources.Resources.KingHuskyHead
        Me.PanelForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PanelForm.Location = New System.Drawing.Point(180, 35)
        Me.PanelForm.Name = "PanelForm"
        Me.PanelForm.Size = New System.Drawing.Size(620, 365)
        Me.PanelForm.TabIndex = 2
        '
        'btnTarea
        '
        Me.btnTarea.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTarea.FlatAppearance.BorderSize = 0
        Me.btnTarea.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnTarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTarea.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTarea.Image = Global.IIIParcial.My.Resources.Resources.virus_covid_coronavirus_home_work_teleworking_icon_141578
        Me.btnTarea.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTarea.Location = New System.Drawing.Point(12, 129)
        Me.btnTarea.Name = "btnTarea"
        Me.btnTarea.Size = New System.Drawing.Size(165, 42)
        Me.btnTarea.TabIndex = 2
        Me.btnTarea.Text = "Ejercicios Tarea"
        Me.btnTarea.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTarea.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTarea.UseVisualStyleBackColor = True
        '
        'btnClase
        '
        Me.btnClase.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClase.FlatAppearance.BorderSize = 0
        Me.btnClase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnClase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClase.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClase.Image = Global.IIIParcial.My.Resources.Resources.books_3025
        Me.btnClase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClase.Location = New System.Drawing.Point(12, 81)
        Me.btnClase.Name = "btnClase"
        Me.btnClase.Size = New System.Drawing.Size(165, 42)
        Me.btnClase.TabIndex = 0
        Me.btnClase.Text = "Ejercicios Clase"
        Me.btnClase.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClase.UseVisualStyleBackColor = True
        '
        'btnMaximizar
        '
        Me.btnMaximizar.BackgroundImage = Global.IIIParcial.My.Resources.Resources._1492790945_39minimize_84242
        Me.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMaximizar.FlatAppearance.BorderSize = 0
        Me.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaximizar.Location = New System.Drawing.Point(724, 0)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.Size = New System.Drawing.Size(35, 32)
        Me.btnMaximizar.TabIndex = 2
        Me.btnMaximizar.UseVisualStyleBackColor = True
        '
        'btnRestaurar
        '
        Me.btnRestaurar.BackgroundImage = Global.IIIParcial.My.Resources.Resources.window_maximize_icon_144029
        Me.btnRestaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRestaurar.FlatAppearance.BorderSize = 0
        Me.btnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestaurar.Location = New System.Drawing.Point(724, 0)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(35, 32)
        Me.btnRestaurar.TabIndex = 4
        Me.btnRestaurar.UseVisualStyleBackColor = True
        '
        'btnMinimizar
        '
        Me.btnMinimizar.BackgroundImage = Global.IIIParcial.My.Resources.Resources.window_minimize_icon_144028
        Me.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimizar.FlatAppearance.BorderSize = 0
        Me.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizar.Location = New System.Drawing.Point(683, 0)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(35, 32)
        Me.btnMinimizar.TabIndex = 3
        Me.btnMinimizar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.BackgroundImage = Global.IIIParcial.My.Resources.Resources._1487086345_cross_81577
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Location = New System.Drawing.Point(765, 0)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(35, 32)
        Me.btnSalir.TabIndex = 1
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Menú
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 400)
        Me.Controls.Add(Me.PanelForm)
        Me.Controls.Add(Me.PanelLateral)
        Me.Controls.Add(Me.PanelSuperior)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Menú"
        Me.Text = "Menú"
        Me.PanelSuperior.ResumeLayout(False)
        Me.PanelLateral.ResumeLayout(False)
        Me.PanelLateral.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelSuperior As Panel
    Friend WithEvents btnMaximizar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents PanelLateral As Panel
    Friend WithEvents btnClase As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnTarea As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnRestaurar As Button
    Friend WithEvents PanelForm As Panel
End Class
