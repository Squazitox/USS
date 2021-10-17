
EXECUTE SP_RegistraProveedor 'PRO001','1A0','91600','JCR INGENIERIA INDUSTRIAL','2062154856', '598-25115121', 'INFO@JCR.COM.UY', 'MATEO CORTE 4941 - CP 11400 MONTEVIDEO'

EXECUTE SP_RegistraProveedor 'PRO002','1B1','69900-000','TROX DO BRASIL DIFUSAO DE','2012452545', '55-413316-8418', 'OI_CRISTINA@TROXBRASIL.COM.BR', 'RUA CYRO COREIA PEREIRA, 300-CIC'
EXECUTE SP_RegistraProveedor 'PRO003','1C2','110911','UNION CARGO INTERNACIONAL','2032565482', '(57) 1 4215832', 'GCOMERCIAL@UNIONCARGO.NET', 'CR 106 23 D-50 P-3 DISTRITO CAPITAL'
EXECUTE SP_RegistraProveedor 'PRO004','1D3','33126','UNION SOUTH INTERNATIONAL','524526548', '305 539-1057', 'INFO@JCR.COM.UY', '1948 NW 82ND AVE, DORAL, FL'
EXECUTE SP_RegistraProveedor 'PRO005','1E4','91600','COSBERT SA','2545254858', '59825182965', 'LUCIA.GOMEZ@LATAM.INTERFOOD.COM', 'RUTA 8, KM 17.500 EDIFICIO BIOTEC PLAZAX'
EXECUTE SP_RegistraProveedor 'PRO006','1F5','56130','VERBEAI INGREDIENTS & PAI','0033299912485', '598-25115121', 'PHILIPPE.LERAV@VINPAI.FR', '6 PARC DACTIVITÉS DE LA FOUÉE'
EXECUTE SP_RegistraProveedor 'PRO007','1G6','370 03','VISCOFAN CZ S.R.O.','10266589455', '34 948 198 444', 'LUIS@QUIMSAPERU.COM', 'XFCP+F2 ?ESKÉ BUD?JOVICE, CHEQUIA'
EXECUTE SP_RegistraProveedor 'PRO008','1H7','69900-000','VISCOFAN DO BRASIL SOC. C','202565455552', '(11) 5180-7400', 'LUIS@QUIMSAPERU.COM', 'AV. ROQUE PETRONI JUNIERO,  - 1 ANDAR'


Select * from tbProveedor


CREATE PROCEDURE SP_RegistraProveedor
@codProveedor varchar(10),
@codPais varchar(10),
@codigoPostal varchar(20),
@RazonSocial varchar(50),
@rucProveedor varchar(13),
@fonoProveedor varchar(12),
@emailProveedor varchar(50),
@direccion varchar(50)
AS
	DECLARE @totalReg int
	DECLARE @enlazado varchar(8)
	SELECT @totalReg = COUNT(*) FROM tbProveedor
	SET @enlazado = @codProveedor +CAST(@totalReg AS varchar(6))
	

	IF EXISTS(SELECT *FROM tbProveedor WHERE tbProveedor.idProveedor= @enlazado)
	BEGIN
		PRINT 'Id ya registrado por favor haga modificacion en letras...';
	END
	ELSE
	BEGIN
		INSERT INTO  tbProveedor VALUES(@enlazado,@codPais,@codigoPostal, @RazonSocial, @rucProveedor,
		@fonoProveedor,@emailProveedor,@direccion)
		PRINT 'Los datos  fueron registrados  en la tabla [PROVEEDOR] con exito...!'
	END
GO

