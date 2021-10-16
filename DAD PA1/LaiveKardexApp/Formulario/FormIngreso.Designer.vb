<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormIngreso
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PIngresoFiltros = New System.Windows.Forms.Panel()
        Me.BIngresoEliminar = New System.Windows.Forms.Button()
        Me.BIngresoIngresar = New System.Windows.Forms.Button()
        Me.CBIngresoOrigen = New System.Windows.Forms.ComboBox()
        Me.DTPIngreso = New System.Windows.Forms.DateTimePicker()
        Me.TBIngresoFactura = New System.Windows.Forms.TextBox()
        Me.TBIngresoLote = New System.Windows.Forms.TextBox()
        Me.TBIngresoCantidad = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PIngresoData = New System.Windows.Forms.Panel()
        Me.DGVIngreso = New System.Windows.Forms.DataGridView()
        Me.PIngresoBotones = New System.Windows.Forms.Panel()
        Me.BIngresoCancelar = New System.Windows.Forms.Button()
        Me.BIngresoGuardar = New System.Windows.Forms.Button()
        Me.BIngresoExportar = New System.Windows.Forms.Button()
        Me.TBIngresoValor = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CBIngresoCodigo = New System.Windows.Forms.ComboBox()
        Me.CBIngresoProveedor = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TBIngresoDescrip = New System.Windows.Forms.TextBox()
        Me.PIngresoFiltros.SuspendLayout()
        Me.PIngresoData.SuspendLayout()
        CType(Me.DGVIngreso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PIngresoBotones.SuspendLayout()
        Me.SuspendLayout()
        '
        'PIngresoFiltros
        '
        Me.PIngresoFiltros.BackColor = System.Drawing.Color.ForestGreen
        Me.PIngresoFiltros.Controls.Add(Me.CBIngresoProveedor)
        Me.PIngresoFiltros.Controls.Add(Me.CBIngresoCodigo)
        Me.PIngresoFiltros.Controls.Add(Me.TBIngresoValor)
        Me.PIngresoFiltros.Controls.Add(Me.Label8)
        Me.PIngresoFiltros.Controls.Add(Me.BIngresoEliminar)
        Me.PIngresoFiltros.Controls.Add(Me.BIngresoIngresar)
        Me.PIngresoFiltros.Controls.Add(Me.CBIngresoOrigen)
        Me.PIngresoFiltros.Controls.Add(Me.DTPIngreso)
        Me.PIngresoFiltros.Controls.Add(Me.TBIngresoFactura)
        Me.PIngresoFiltros.Controls.Add(Me.TBIngresoLote)
        Me.PIngresoFiltros.Controls.Add(Me.TBIngresoDescrip)
        Me.PIngresoFiltros.Controls.Add(Me.TBIngresoCantidad)
        Me.PIngresoFiltros.Controls.Add(Me.Label7)
        Me.PIngresoFiltros.Controls.Add(Me.Label6)
        Me.PIngresoFiltros.Controls.Add(Me.Label5)
        Me.PIngresoFiltros.Controls.Add(Me.Label4)
        Me.PIngresoFiltros.Controls.Add(Me.Label3)
        Me.PIngresoFiltros.Controls.Add(Me.Label9)
        Me.PIngresoFiltros.Controls.Add(Me.Label2)
        Me.PIngresoFiltros.Controls.Add(Me.Label1)
        Me.PIngresoFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.PIngresoFiltros.Location = New System.Drawing.Point(0, 0)
        Me.PIngresoFiltros.Name = "PIngresoFiltros"
        Me.PIngresoFiltros.Size = New System.Drawing.Size(800, 146)
        Me.PIngresoFiltros.TabIndex = 0
        '
        'BIngresoEliminar
        '
        Me.BIngresoEliminar.Location = New System.Drawing.Point(632, 100)
        Me.BIngresoEliminar.Name = "BIngresoEliminar"
        Me.BIngresoEliminar.Size = New System.Drawing.Size(75, 33)
        Me.BIngresoEliminar.TabIndex = 16
        Me.BIngresoEliminar.Text = "Eliminar"
        Me.BIngresoEliminar.UseVisualStyleBackColor = True
        '
        'BIngresoIngresar
        '
        Me.BIngresoIngresar.Location = New System.Drawing.Point(713, 100)
        Me.BIngresoIngresar.Name = "BIngresoIngresar"
        Me.BIngresoIngresar.Size = New System.Drawing.Size(75, 33)
        Me.BIngresoIngresar.TabIndex = 15
        Me.BIngresoIngresar.Text = "Ingresar"
        Me.BIngresoIngresar.UseVisualStyleBackColor = True
        '
        'CBIngresoOrigen
        '
        Me.CBIngresoOrigen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CBIngresoOrigen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CBIngresoOrigen.FormattingEnabled = True
        Me.CBIngresoOrigen.Items.AddRange(New Object() {"CHECOSLOVAQUIA", "ZONAS FRANCAS DEL PERU", "PAISES NO PREC. EN OP. ABAST. COMBUST", "AGUAS INTERNACIONALES", "NO DECLARADOS", "GAZA Y JERICO", "ESCOCIA", "URSS", "VIETNAM (DEL NORTE)", "COMUNIDAD ECONOMICA EUROPEA", "COSTA DE MARFIL", "ZONA DEL CANAL DE PANAMA", "ALEMANIA", "ISLAS NORMANDAS", "CANTON Y ENDERBURRY", "HONDURAS BRITANICAS", "ISALAS JONSTON", "MACEDONIA", "MIDWAY, ISLAS", "ISLAS DE PACIFICO", "REPUBLICA ARABE UNIDA", "WAKE, ISLA", "TERRITORIO AUTONOMO DE PALESTINA.", "TODOS LOS PAISES", "ANDORRA", "EMIRATOS ÁRABES UNIDOS", "AFGANISTÁN", "ANTIGUA Y BARBUDA", "ANGUILA", "ALBANIA", "ARMENIA", "ANTILLAS HOLANDESAS", "ANGOLA", "ANTÁRTIDA", "ARGENTINA", "SAMOA AMERICANA", "AUSTRIA", "AUSTRALIA", "ARUBA", "ISLAS ALAND", "AZERBAIJAN", "BOSNIA Y HERZEGOVINA", "BARBADOS", "BANGLADESH", "BÉLGICA", "BURKINA FASO", "BULGARIA", "BAHREIN", "BURUNDI", "BENIN", "SANTA BARTHELEMY", "ISLAS BERMUDAS", "BRUNEI DARUSSALAM", "BOLIVIA", "BONAIRE", "BRASIL", "BAHAMAS", "BHUTAN", "ISLA DE BOUVET", "BOTSWANA", "BELARUS", "BELICE", "CANADÁ", "COCOS (KEELING) ISLAS", "CONGO LA REPÚBLICA DEMOCRÁTICA DE LA", "REPÚBLICA CENTROAFRICANA", "CONGO", "SUIZA", "COTE IVOIRE", "ISLAS COOK", "CHILE", "CAMERÚN", "CHINA", "COLOMBIA", "COSTA RICA", "SERBIA Y MONTENEGRO", "CUBA", "CABO VERDE", "CURAZAO", "ISLA DE NAVIDAD", "CHIPRE", "REPUBLICA CHECA", "ALEMANIA", "DJIBOUTI", "DINAMARCA", "DOMINICA", "REPÚBLICA DOMINICANA", "ARGELIA", "ECUADOR", "ESTONIA", "EGIPTO", "SAHARA OCCIDENTAL", "ERITREA", "ESPAÑA", "ETIOPÍA", "FINLANDIA", "FIJI", "ISLAS MALVINAS (MALVINAS)", "MICRONESIA, ESTADOS FEDERADOS DE", "ISLAS FAROE", "FRANCIA", "FRANCIA, METROPOLITANO", "GABÓN", "REINO UNIDO", "GRANADA", "GEORGIA", "GUIANA FRANCESA", "GUERNSEY", "GHANA", "GIBRALTAR", "TIERRA VERDE", "GAMBIA", "GUINEA", "GUADALUPE", "GUINEA ECUATORIAL", "GRECIA", "GEORGIA DEL SUR Y LAS ISLAS SANDWICH DEL", "GUATEMALA", "GUAM", "GUINEA-BISSAU", "GUAYANA", "HONG KONG", "ISLA DEL OÍDO Y LAS ISLAS MDDALLD", "HONDURAS", "CROACIA", "HAITÍ", "HUNGRÍA", "INDONESIA", "IRLANDA", "ISRAEL", "ISLA DEL HOMBRE", "INDIA", "TERRITORIO BRITÁNICO DEL OCÉANO ÍNDICO", "IRAK", "IRÁN (REPÚBLICA ISLÁMICA DE", "ISLANDIA", "ITALIA", "JERSEY", "JAMAICA", "JORDÁN", "JAPÓN", "KENIA", "KYRGYZSTAN", "CAMBOYA", "KIRIBATI", "COMORES", "SAINT KITTS Y NEVIS", "COREA, REP. DE LAS PERSONAS DEMOCRATICAS", "COREA, REPÚBLICA DE", "KUWAIT", "ISLAS CAIMÁN", "KAZAJSTÁN", "REPÚBLICA DEMOCRÁTICA POPULAR DE LAO", "LÍBANO", "SANTA LUCÍA", "LIECHTENSTEIN", "SRI LANKA", "LIBERIA", "LESOTO", "LITUANIA", "LUXEMBURGO", "LETONIA", "LIBIA", "MARRUECOS", "MÓNACO", "MOLDAVIA, REPÚBLICA DE", "MONTENEGRO", "SAN MARTIN (PARTE FRANCESA)", "MADAGASCAR", "ISLAS MARSHALL", "MACEDONIA, LA ANTIGUA REPÚBLICA YUGOSLAV", "MALI", "MYANMAR", "MONGOLIA", "MACAO", "ISLAS MARIANAS DEL NORTE", "MARTINICA", "MAURITANIA", "MONTSERRAT", "MALTA", "MAURICIO", "MALDIVAS", "MALAWI", "MEXICO", "MALASIA", "MOZAMBIQUE", "NAMIBIA", "NUEVA CALEDONIA", "NÍGER", "ISLA NORFOLK", "NIGERIA", "NICARAGUA", "PAÍSES BAJOS", "NORUEGA", "NEPAL", "NAURU", "ZONA NEUTRAL", "NIUE", "NUEVA ZELANDA", "OMÁN", "PANAMÁ", "PERÚ", "POLINESIA FRANCÉS", "PAPÚA NUEVA GUINEA", "FILIPINAS", "PAKISTÁN", "POLONIA", "SAN PIERRE Y MIQUELON", "PITCAIRN", "PUERTO RICO", "PALESTINA, ESTADO DE", "PORTUGAL", "PALAU", "PARAGUAY", "KATAR", "REUNIÓN", "RUMANIA", "SERBIA", "FEDERACIÓN RUSA", "RUANDA", "ARABIA SAUDITA", "ISLAS SALOMÓN", "SEYCHELLES", "SUDÁN", "SUECIA", "SINGAPUR", "SANTA HELENA, ASCENSIÓN Y TRISTÁN DA CUN", "ESLOVENIA", "SVALBARD Y JAN MAYEN", "ESLOVAQUIA", "SIERRA LEONA", "SAN MARINO", "SENEGAL", "SOMALIA", "SURINAME", "SUDÁN DEL SUR", "SANTO TOMÉ Y PRÍNCIPE", "EL SALVADOR", "SINT MAARTEN (PARTE HOLANDESA)", "REPÚBLICA ÁRABE SIRIA", "SWAZILANDIA", "ISLAS TURCAS Y CAICOS", "CHAD", "TERRITORIOS FRANCESES DEL SUR", "TOGO", "TAILANDIA", "TAYIKISTAN", "TOKAELU", "TIMOR-LESTE", "TURKMENISTÁN", "TÚNEZ", "TONGA", "TIMOR ORIENTAL", "TURQUIA", "TRINIDAD Y TOBAGO", "TUVALU", "TAIWAN, PROVINCIA DE CHINA", "TANZANIA, REPÚBLICA DE LOS ESTADOS UNIDO", "UCRANIA", "UGANDA", "ISLAS MENORES DE LOS ESTADOS UNIDOS", "ESTADOS UNIDOS", "URUGUAY", "UZBEKISTÁN", "SANTA SEDE (ESTADO DE LA CIUDAD DEL VATI", "SAN VICENTE Y LAS GRANADINAS", "VENEZUELA", "ISLAS VÍRGENES BRITÁNICAS", "ISLAS VÍRGENES, EE. UU.", "VIET NAM", "VANUATU", "WALLIS Y FUTUNA", "SAMOA", "PUEBA", "INSTALACIONES EN AGUA INTERNACIONAL", "YEMEN", "MAYOTTE", "YUGOSLAVIA", "SUDÁFRICA", "ZAMBIA", "ZAIRE", "ZIMBABUE"})
        Me.CBIngresoOrigen.Location = New System.Drawing.Point(597, 35)
        Me.CBIngresoOrigen.Name = "CBIngresoOrigen"
        Me.CBIngresoOrigen.Size = New System.Drawing.Size(121, 21)
        Me.CBIngresoOrigen.TabIndex = 14
        '
        'DTPIngreso
        '
        Me.DTPIngreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPIngreso.Location = New System.Drawing.Point(168, 118)
        Me.DTPIngreso.MaxDate = New Date(2030, 12, 31, 0, 0, 0, 0)
        Me.DTPIngreso.MinDate = New Date(2019, 1, 1, 0, 0, 0, 0)
        Me.DTPIngreso.Name = "DTPIngreso"
        Me.DTPIngreso.Size = New System.Drawing.Size(113, 20)
        Me.DTPIngreso.TabIndex = 13
        '
        'TBIngresoFactura
        '
        Me.TBIngresoFactura.Location = New System.Drawing.Point(492, 62)
        Me.TBIngresoFactura.Name = "TBIngresoFactura"
        Me.TBIngresoFactura.Size = New System.Drawing.Size(147, 20)
        Me.TBIngresoFactura.TabIndex = 12
        '
        'TBIngresoLote
        '
        Me.TBIngresoLote.Location = New System.Drawing.Point(117, 90)
        Me.TBIngresoLote.Name = "TBIngresoLote"
        Me.TBIngresoLote.Size = New System.Drawing.Size(164, 20)
        Me.TBIngresoLote.TabIndex = 9
        '
        'TBIngresoCantidad
        '
        Me.TBIngresoCantidad.Location = New System.Drawing.Point(117, 62)
        Me.TBIngresoCantidad.Name = "TBIngresoCantidad"
        Me.TBIngresoCantidad.Size = New System.Drawing.Size(164, 20)
        Me.TBIngresoCantidad.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Mont Demo Heavy", 10.0!)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(521, 36)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 19)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Origen:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Mont Demo Heavy", 10.0!)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(397, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 19)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Nº Factura:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Mont Demo Heavy", 10.0!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(408, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Proveedor:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Mont Demo Heavy", 10.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "F. Vencimiento"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Mont Demo Heavy", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Lote:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Mont Demo Heavy", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cantidad:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mont Demo Heavy", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cod. Producto:"
        '
        'PIngresoData
        '
        Me.PIngresoData.Controls.Add(Me.DGVIngreso)
        Me.PIngresoData.Dock = System.Windows.Forms.DockStyle.Top
        Me.PIngresoData.Location = New System.Drawing.Point(0, 146)
        Me.PIngresoData.Name = "PIngresoData"
        Me.PIngresoData.Size = New System.Drawing.Size(800, 285)
        Me.PIngresoData.TabIndex = 1
        '
        'DGVIngreso
        '
        Me.DGVIngreso.AllowUserToOrderColumns = True
        Me.DGVIngreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVIngreso.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVIngreso.Location = New System.Drawing.Point(0, 0)
        Me.DGVIngreso.Name = "DGVIngreso"
        Me.DGVIngreso.Size = New System.Drawing.Size(800, 285)
        Me.DGVIngreso.TabIndex = 0
        '
        'PIngresoBotones
        '
        Me.PIngresoBotones.BackColor = System.Drawing.Color.ForestGreen
        Me.PIngresoBotones.Controls.Add(Me.BIngresoCancelar)
        Me.PIngresoBotones.Controls.Add(Me.BIngresoGuardar)
        Me.PIngresoBotones.Controls.Add(Me.BIngresoExportar)
        Me.PIngresoBotones.Dock = System.Windows.Forms.DockStyle.Top
        Me.PIngresoBotones.Location = New System.Drawing.Point(0, 431)
        Me.PIngresoBotones.Name = "PIngresoBotones"
        Me.PIngresoBotones.Size = New System.Drawing.Size(800, 64)
        Me.PIngresoBotones.TabIndex = 2
        '
        'BIngresoCancelar
        '
        Me.BIngresoCancelar.Location = New System.Drawing.Point(583, 16)
        Me.BIngresoCancelar.Name = "BIngresoCancelar"
        Me.BIngresoCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BIngresoCancelar.TabIndex = 2
        Me.BIngresoCancelar.Text = "Cancelar"
        Me.BIngresoCancelar.UseVisualStyleBackColor = True
        '
        'BIngresoGuardar
        '
        Me.BIngresoGuardar.Location = New System.Drawing.Point(678, 16)
        Me.BIngresoGuardar.Name = "BIngresoGuardar"
        Me.BIngresoGuardar.Size = New System.Drawing.Size(75, 23)
        Me.BIngresoGuardar.TabIndex = 1
        Me.BIngresoGuardar.Text = "Guardar"
        Me.BIngresoGuardar.UseVisualStyleBackColor = True
        '
        'BIngresoExportar
        '
        Me.BIngresoExportar.Location = New System.Drawing.Point(12, 16)
        Me.BIngresoExportar.Name = "BIngresoExportar"
        Me.BIngresoExportar.Size = New System.Drawing.Size(75, 23)
        Me.BIngresoExportar.TabIndex = 0
        Me.BIngresoExportar.Text = "Exportar"
        Me.BIngresoExportar.UseVisualStyleBackColor = True
        '
        'TBIngresoValor
        '
        Me.TBIngresoValor.Location = New System.Drawing.Point(713, 65)
        Me.TBIngresoValor.Name = "TBIngresoValor"
        Me.TBIngresoValor.Size = New System.Drawing.Size(55, 20)
        Me.TBIngresoValor.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Mont Demo Heavy", 10.0!)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(657, 65)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 19)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Valor :"
        '
        'CBIngresoCodigo
        '
        Me.CBIngresoCodigo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CBIngresoCodigo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CBIngresoCodigo.FormattingEnabled = True
        Me.CBIngresoCodigo.Location = New System.Drawing.Point(136, 8)
        Me.CBIngresoCodigo.Name = "CBIngresoCodigo"
        Me.CBIngresoCodigo.Size = New System.Drawing.Size(164, 21)
        Me.CBIngresoCodigo.TabIndex = 19
        '
        'CBIngresoProveedor
        '
        Me.CBIngresoProveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CBIngresoProveedor.FormattingEnabled = True
        Me.CBIngresoProveedor.Location = New System.Drawing.Point(503, 12)
        Me.CBIngresoProveedor.Name = "CBIngresoProveedor"
        Me.CBIngresoProveedor.Size = New System.Drawing.Size(216, 21)
        Me.CBIngresoProveedor.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AllowDrop = True
        Me.Label9.AutoSize = True
        Me.Label9.Enabled = False
        Me.Label9.Font = New System.Drawing.Font("Mont Demo Heavy", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(12, 35)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 19)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Descripcion:"
        '
        'TBIngresoDescrip
        '
        Me.TBIngresoDescrip.Location = New System.Drawing.Point(117, 34)
        Me.TBIngresoDescrip.Name = "TBIngresoDescrip"
        Me.TBIngresoDescrip.ReadOnly = True
        Me.TBIngresoDescrip.Size = New System.Drawing.Size(283, 20)
        Me.TBIngresoDescrip.TabIndex = 8
        '
        'FormIngreso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 494)
        Me.Controls.Add(Me.PIngresoBotones)
        Me.Controls.Add(Me.PIngresoData)
        Me.Controls.Add(Me.PIngresoFiltros)
        Me.Name = "FormIngreso"
        Me.Text = "FormIngreso"
        Me.PIngresoFiltros.ResumeLayout(False)
        Me.PIngresoFiltros.PerformLayout()
        Me.PIngresoData.ResumeLayout(False)
        CType(Me.DGVIngreso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PIngresoBotones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PIngresoFiltros As Panel
    Friend WithEvents BIngresoIngresar As Button
    Friend WithEvents CBIngresoOrigen As ComboBox
    Friend WithEvents DTPIngreso As DateTimePicker
    Friend WithEvents TBIngresoFactura As TextBox
    Friend WithEvents TBIngresoLote As TextBox
    Friend WithEvents TBIngresoCantidad As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PIngresoData As Panel
    Friend WithEvents DGVIngreso As DataGridView
    Friend WithEvents PIngresoBotones As Panel
    Friend WithEvents BIngresoCancelar As Button
    Friend WithEvents BIngresoGuardar As Button
    Friend WithEvents BIngresoExportar As Button
    Friend WithEvents BIngresoEliminar As Button
    Friend WithEvents TBIngresoValor As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents CBIngresoProveedor As ComboBox
    Friend WithEvents CBIngresoCodigo As ComboBox
    Friend WithEvents TBIngresoDescrip As TextBox
    Friend WithEvents Label9 As Label
End Class
