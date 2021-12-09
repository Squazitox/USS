var tablaproducto;
var tablacliente;
var tablaPlanta;
var tablaproductoArea;

$(document).ready(function () {

    activarMenu("Ventas");
    $("#txtproductocantidad").val("0");
    $("#txtfechaventa").val(ObtenerFecha());


    //OBTENER PROVEEDORES
    jQuery.ajax({
        url: $.MisUrls.url._ObtenerUsuario,
        type: "GET",
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        success: function (data) {
            //TIENDA
            $("#txtIdTienda").val(data.oTienda.IdTienda);
            $("#lbltiendanombre").text(data.oTienda.Nombre);
            $("#lbltiendaruc").text(data.oTienda.RUC);
            $("#lbltiendadireccion").text(data.oTienda.Direccion);

            //USUARIO
            $("#txtIdUsuario").val(data.IdUsuario);
            $("#lblempleadonombre").text(data.Nombres);
            $("#lblempleadoapellido").text(data.Apellidos);
            $("#lblempleadocorreo").text(data.Correo);
        },
        error: function (error) {
            console.log(error)
        },
        beforeSend: function () {
            $("#cboProveedor").LoadingOverlay("show");
        },
    });


    //OBTENER PRODUCTOS
    //tablaproducto = $('#tbProducto').DataTable({
    //    "ajax": {
    //        "url": $.MisUrls.url._ObtenerProductoStockPorTienda + "?IdTienda=0",
    //        "type": "GET",
    //        "datatype": "json"
    //    },
    //    "columns": [
    //        {
    //            "data": "IdProductoTienda", "render": function (data, type, row, meta) {
    //                return "<button class='btn btn-sm btn-primary ml-2' type='button' onclick='productoSelect(" + JSON.stringify(row) + ")'><i class='fas fa-check'></i></button>"
    //            },
    //            "orderable": false,
    //            "searchable": false,
    //            "width": "90px"
    //        },
    //        {
    //            "data": "oProducto", render: function (data) {
    //                return data.Codigo
    //            }
    //        },
    //        {
    //            "data": "oProducto", render: function (data) {
    //                return data.Nombre
    //            }
    //        },
    //        {
    //            "data": "oProducto", render: function (data) {
    //                return data.Descripcion
    //            }
    //        },
    //        { "data": "Stock" }

    //    ],
    //    "language": {
    //        "url": $.MisUrls.url.Url_datatable_spanish
    //    },
    //    responsive: true
    //});

    tablaproductoArea = $('#tbProductoArea').DataTable({
        "ajax": {
            /*"url": $.MisUrls.url._ObtenerProductosPorTienda + "?IdTienda=0",*/
            "url": $.MisUrls.url._ObtenerProductosPorArea,
            "type": "GET",
            "datatype": "json"
        },
        "columns": [
            {
                "data": "idProducto", "render": function (data, type, row, meta) {
                    /*control.log(data);*/
                    return "<button class='btn btn-sm btn-primary ml-2' type='button' onclick='productoSelectArea(" + JSON.stringify(row) + ")'><i class='fas fa-check'></i></button>"
                },
                "orderable": false,
                "searchable": false,
                "width": "90px"
            },
            { "data": "idProducto" },
            { "data": "descripcion" },
            { "data": "seccion" },
            { "data": "lote" },


            //{ "data": "Descripcion" },
            //{
            //    "data": "oCategoria", render: function (data) {
            //        return data.Descripcion
            //    }
            //}

        ],
        "language": {
            "url": $.MisUrls.url.Url_datatable_spanish
        },
        responsive: true
    });

    //tablacliente = $('#tbcliente').DataTable({
    //    "ajax": {
    //        "url": $.MisUrls.url._ObtenerClientes,
    //        "type": "GET",
    //        "datatype": "json"
    //    },
    //    "columns": [
    //        {
    //            "data": "IdCliente", "render": function (data, type, row, meta) {
    //                return "<button class='btn btn-sm btn-primary ml-2' type='button' onclick='clienteSelect(" + JSON.stringify(row) + ")'><i class='fas fa-check'></i></button>"
    //            },
    //            "orderable": false,
    //            "searchable": false,
    //            "width": "90px"
    //        },
    //        { "data": "TipoDocumento" },
    //        { "data": "NumeroDocumento" },
    //        { "data": "Nombre" },
    //        { "data": "Direccion" }
    //    ],
    //    "language": {
    //        "url": $.MisUrls.url.Url_datatable_spanish
    //    },
    //    responsive: true
    //});
    //OBTENER TIENDAS
    tablaPlanta = $('#tbPlanta').DataTable({
        "ajax": {
            "url": $.MisUrls.url._ObtenerPlanta,
            "type": "GET",
            "datatype": "json"
        },
        "columns": [
            {
                "data": "idArea", "render": function (data, type, row, meta) {
                    return "<button class='btn btn-sm btn-primary ml-2' type='button' onclick='tiendaSelect(" + JSON.stringify(row) + ")'><i class='fas fa-check'></i></button>"
                },
                "orderable": false,
                "searchable": false,
                "width": "90px"
            },
            { "data": "idArea" },
            { "data": "nombreArea" },
            //{ "data": "Direccion" }

        ],
        "language": {
            "url": $.MisUrls.url.Url_datatable_spanish
        },
        responsive: true
    });

})

function ObtenerFecha() {

    var d = new Date();
    var month = d.getMonth() + 1;
    var day = d.getDate();
    var output = (('' + day).length < 2 ? '0' : '') + day + '/' + (('' + month).length < 2 ? '0' : '') + month + '/' + d.getFullYear();

    return output;
}

function buscarPlanta() {
    tablaPlanta.ajax.reload();
    $('#modalTienda').modal('show');
}

function buscarProducto() {

    //alert(1);
    //if (parseInt($("#txtIdTienda").val()) == 0) {
    //    swal("Mensaje", "Debe seleccionar una tienda primero", "warning")
    //    return;
    //}
    /*tablaproducto.ajax.url($.MisUrls.url._ObtenerProductosPorTienda + "?IdTienda=" + $("#txtIdTienda").val()).load();*/
    tablaproductoArea.ajax.reload();

    $('#modalProducto').modal('show');
}

$.fn.inputFilter = function (inputFilter) {
    return this.on("input keydown keyup mousedown mouseup select contextmenu drop", function () {
        if (inputFilter(this.value)) {
            this.oldValue = this.value;
            this.oldSelectionStart = this.selectionStart;
            this.oldSelectionEnd = this.selectionEnd;
        } else if (this.hasOwnProperty("oldValue")) {
            this.value = this.oldValue;
            this.setSelectionRange(this.oldSelectionStart, this.oldSelectionEnd);
        } else {
            this.value = "";
        }
    });
};

$("#txtproductocantidad").inputFilter(function (value) {
    return /^-?\d*$/.test(value);
});

$("#txtmontopago").inputFilter(function (value) {
    return /^-?\d*[.]?\d{0,2}$/.test(value);
});

//$('#btnBuscarProducto').on('click', function () {

  
//    tablaproducto.ajax.url($.MisUrls.url._ObtenerProductoStockPorTienda + "?IdTienda=" + parseInt($("#txtIdTienda").val()) ).load();

//    $('#modalProducto').modal('show');
//})

$('#btnBuscarCliente').on('click', function () {

    tablacliente.ajax.reload();

    $('#modalCliente').modal('show');
})

function tiendaSelect(json) {
    $("#txtidPlanta").val(json.idArea);
    $("#txtNombrePlanta").val(json.nombreArea);
    //$("#txtNombreTienda").val(json.Nombre);

    $('#modalTienda').modal('hide');
}

//function productoSelect(json) {
//    $("#txtIdProducto").val(json.oProducto.IdProducto);
//    $("#txtproductocodigo").val(json.oProducto.Codigo);
//    $("#txtproductonombre").val(json.oProducto.Nombre);
//    $("#txtproductodescripcion").val(json.oProducto.Descripcion);
//    $("#txtproductostock").val(json.Stock);
//    $("#txtproductoprecio").val(json.PrecioUnidadVenta);
//    $("#txtproductocantidad").val("0");
//    $('#modalProducto').modal('hide');
//}

function productoSelectArea(json) {
    $("#txtCodigoProducto").val(json.idProducto);
    $("#txtNombreProducto").val(json.descripcion);
    $("#txtUbicacion").val(json.seccion);
    $("#txtLote").val(json.lote);
/*    $("#txtFechaVencimiento").val(json.caducidad);*/
    $('#modalProducto').modal('hide');
}

function clienteSelect(json) {

    $("#cboclientetipodocumento").val(json.TipoDocumento);
    $("#txtclientedocumento").val(json.NumeroDocumento);
    $("#txtclientenombres").val(json.Nombre);
    $("#txtclientedireccion").val(json.Direccion);
    $("#txtclientetelefono").val(json.Telefono);
    $('#modalCliente').modal('hide');
}

//$("#txtproductocodigo").on('keypress', function (e) {


//    if (e.which == 13) {

//        var request = { IdTienda: parseInt($("#txtIdTienda").val()) }


//        //OBTENER PROVEEDORES
//        jQuery.ajax({
//            url: $.MisUrls.url._ObtenerProductoStockPorTienda + "?IdTienda=" + parseInt($("#txtIdTienda").val()),
//            type: "GET",
//            dataType: "json",
//            contentType: "application/json; charset=utf-8",
//            success: function (data) {

//                var encontrado = false;
//                if (data.data != null) {
//                    $.each(data.data, function (i, item) {
//                        if (item.oProducto.Codigo == $("#txtproductocodigo").val()) {

//                            $("#txtIdProducto").val(item.oProducto.IdProducto);
//                            $("#txtproductocodigo").val(item.oProducto.Codigo);
//                            $("#txtproductonombre").val(item.oProducto.Nombre);
//                            $("#txtproductodescripcion").val(item.oProducto.Descripcion);
//                            $("#txtproductostock").val(item.Stock);
//                            $("#txtproductoprecio").val(item.PrecioUnidadVenta);
//                            encontrado = true;
//                            return false;
//                        }
//                    })

//                    if (!encontrado) {

//                        $("#txtIdProducto").val("0");
//                        $("#txtproductocodigo").val("");
//                        $("#txtproductonombre").val("");
//                        $("#txtproductodescripcion").val("");
//                        $("#txtproductostock").val("");
//                        $("#txtproductoprecio").val("");
//                        $("#txtproductocantidad").val("0");

//                    }
//                }

//            },
//            error: function (error) {
//                console.log(error)
//            },
//            beforeSend: function () {
//                $("#cboProveedor").LoadingOverlay("show");
//            },
//        });



//    }
//});

$("#txtCodigoProducto").on('keypress', function (e) {

    if (e.which == 13) {

        //OBTENER PRODUCTOS
        jQuery.ajax({
            url: $.MisUrls.url._ObtenerProductosPorArea,
            type: "GET",
            dataType: "json",
            contentType: "application/json; charset=utf-8",
            success: function (data) {
                $("#txtCodigoProducto").LoadingOverlay("hide");
                var encontrado = false;
                if (data.data != null) {
                    $.each(data.data, function (i, item) {
                        if (item.Activo == true && item.Codigo == $("#txtCodigoProducto").val()) {

                            $("#txtCodigoProducto").val(json.idProducto);
                            $("#txtNombreProducto").val(json.descripcion);
                            $("#txtUbicacion").val(json.seccion);
                            $("#txtLote").val(json.lote);
                            

                            encontrado = true;
                            return false;
                        }
                    })

                    if (!encontrado) {
                        //$("#txtIdProducto").val("0");
                        //$("#txtNombreProducto").val("");
                        $("#txtCodigoProducto").val("0");
                        $("#txtNombreProducto").val("");
                        $("#txtUbicacion").val("");
                        $("#txtLote").val("");
                        
                    }
                }
            },
            error: function (error) {
                console.log(error)
            },
            beforeSend: function () {
                $("#txtCodigoProducto").LoadingOverlay("show");
            },
        });


    }
});

//$('#btnAgregar').on('click', function () {

//    $("#txtproductocantidad").val($("#txtproductocantidad").val() == "" ? "0" : $("#txtproductocantidad").val());

//    var existe_codigo = false;
//    if (
//        parseInt($("#txtIdProducto").val()) == 0 ||
//        parseFloat($("#txtproductocantidad").val()) == 0
//    ) {
//        swal("Mensaje", "Debe completar todos los campos del producto", "warning")
//        return;
//    }

//    $('#tbVenta > tbody  > tr').each(function (index, tr) {
//        var fila = tr;
//        var idproducto = $(fila).find("td.producto").data("idproducto");

//        if (idproducto == $("#txtIdProducto").val()) {
//            existe_codigo = true;
//            return false;
//        }

//    });

//    if (!existe_codigo) {

//        controlarStock(parseInt($("#txtIdProducto").val()), parseInt($("#txtIdTienda").val()), parseInt($("#txtproductocantidad").val()), true);

//        var importetotal = parseFloat($("#txtproductoprecio").val()) * parseFloat($("#txtproductocantidad").val());
//        $("<tr>").append(
//            $("<td>").append(
//                $("<button>").addClass("btn btn-danger btn-sm").text("Eliminar").data("idproducto", parseInt($("#txtIdProducto").val())).data("cantidadproducto", parseInt($("#txtproductocantidad").val()))
//            ),
//            $("<td>").addClass("productocantidad").text($("#txtproductocantidad").val()),
//            $("<td>").addClass("producto").data("idproducto", $("#txtIdProducto").val()).text($("#txtproductonombre").val()),
//            $("<td>").text($("#txtproductodescripcion").val()),
//            $("<td>").addClass("productoprecio").text($("#txtproductoprecio").val()),
//            $("<td>").addClass("importetotal").text(importetotal)
//        ).appendTo("#tbVenta tbody");

//        $("#txtIdProducto").val("0");
//        $("#txtproductocodigo").val("");
//        $("#txtproductonombre").val("");
//        $("#txtproductodescripcion").val("");
//        $("#txtproductostock").val("");
//        $("#txtproductoprecio").val("");
//        $("#txtproductocantidad").val("0");

//        $("#txtproductocodigo").focus();

//        calcularPrecios();
//    } else {
//        swal("Mensaje", "El producto ya existe en la venta", "warning")
//    }
//})

$('#btnAgregarVenta').on('click', function () {

    var existe_codigo = false;
    if (
        parseInt($("#txtidPlanta").val()) == 0 ||
        parseInt($("#txtCodigoProducto").val()) == 0 ||
        parseInt($("#txtCantidadProducto").val()) == 0
        //parseInt($("#txtCodigoProducto").val()) == 0 ||
        //parseInt($("#txtNombreProducto").val()) == 0 ||
        //parseFloat($("#txtCantidadProducto").val()) == 0 ||
        //parseFloat($("#txtPrecioProducto").val()) == 0 ||
        //parseFloat($("#txtFactura").val()) == 0 ||
        //parseFloat($("#txtLote").val()) == 0 ||
        //parseFloat($("#txtFechaVencimiento").val()) == 0 ||
        //parseFloat($("#txtUbicacion").val()) == 0

    ) {
        swal("Mensaje", "Debe completar todos los campos", "warning")
        return;
    }

    $('#tbVentas > tbody  > tr').each(function (index, tr) {
        var fila = tr;
        var codigoproducto = $(fila).find("td.codigoproducto").text();

        if (codigoproducto == $("#txtCodigoProducto").val()) {
            existe_codigo = true;
            return false;
        }

    });

    if (!existe_codigo) {
        $("<tr>").append(
            $("<td>").append(
                $("<button>").addClass("btn btn-danger btn-sm").text("Eliminar")
            ),
            $("<td>").addClass("codigoproducto").data("idproducto", $("#txtIdProducto").val()).append($("#txtCodigoProducto").val()),
            $("<td>").addClass("producto").append($("#txtNombreProducto").val()),
            $("<td>").addClass("planta").append($("#txtNombrePlanta").val()),
            $("<td>").addClass("ubicacion").append($("#txtUbicacion").val()),
            $("<td>").addClass("Lote").append($("#txtLote").val()),
            $("<td>").addClass("cantidad").append($("#txtCantidadProducto").val()),
         

/*            $("<td>").addClass("fechavencimiento").append($("#txtFechaVencimiento").val()),*/




        ).appendTo("#tbVentas tbody");

        $("#txtCodigoProducto").val("")
        $("#txtNombreProducto").val("")
        $("#txtNombrePlanta").val("")
        $("#txtCantidadProducto").val("")
        $("#txtLote").val("")
        $("#txtUbicacion").val("")

    } else {
        swal("Mensaje", "El producto ya existe en ingresos", "warning")
    }
})

//$('#tbVentas tbody').on('click', 'button[class="btn btn-danger btn-sm"]', function () {
//    $(this).parents("tr").remove();
//})

//$('#tbVentas tbody').on('click', 'button[class="btn btn-danger btn-sm"]', function () {
//    var idproducto = $(this).data("idproducto");
//    var cantidadproducto = $(this).data("cantidadproducto");

//    controlarStock(idproducto, parseInt($("#txtIdTienda").val()), cantidadproducto, false);
//    $(this).parents("tr").remove();

//    calcularPrecios();
//})

//$('#btnTerminarGuardarVenta1').on('click', function () {

//    //VALIDACIONES DE CLIENTE
//    //if ($("#txtclientedocumento").val().trim() == "" || $("#txtclientenombres").val().trim() == "") {
//    //    swal("Mensaje", "Complete los datos del cliente", "warning");
//    //    return;
//    //}
//    //VALIDACIONES DE PRODUCTOS
//    if ($('#tbVentas tbody tr').length == 0) {
//        swal("Mensaje", "Debe registrar minimo un producto en la venta", "warning");
//        return;
//    }

//    //VALIDACIONES DE MONTO PAGO
//    if ($("#txtmontopago").val().trim() == "") {
//        swal("Mensaje", "Ingrese el monto de pago", "warning");
//        return;
//    }

//    var $totalproductos = 0;
//    var $totalimportes = 0;

//    var DETALLE = "";
//    var VENTA = "";
//    var DETALLE_CLIENTE = "";
//    var DETALLE_VENTA = "";
//    var DATOS_VENTA = "";

//    calcularCambio();

//    $('#tbVentas > tbody  > tr').each(function (index, tr) {
//        var fila = tr;
//        var productocantidad = parseInt($(fila).find("td.productocantidad").text());
//        var idproducto = $(fila).find("td.producto").data("idproducto");
//        var productoprecio = parseFloat($(fila).find("td.productoprecio").text());
//        var importetotal = parseFloat($(fila).find("td.importetotal").text());

//        $totalproductos = $totalproductos + productocantidad;
//        $totalimportes = $totalimportes + importetotal;

//        DATOS_VENTA = DATOS_VENTA + "<DATOS>" +
//            "<IdVenta>0</IdVenta >" +
//            "<IdProducto>" + idproducto + "</IdProducto>" +
//            "<Cantidad>" + productocantidad + "</Cantidad>" +
//            "<PrecioUnidad>" + productoprecio + "</PrecioUnidad>" +
//            "<ImporteTotal>" + importetotal + "</ImporteTotal>" +
//            "</DATOS>"
//    });


//    VENTA = "<VENTA>" +
//        "<IdTienda>" + $("#txtIdTienda").val() + "</IdTienda>" +
//        "<IdUsuario>" + $("#txtIdUsuario").val() + "</IdUsuario>" +
//        "<IdCliente>0</IdCliente>" +
//        "<TipoDocumento>" + $("#cboventatipodocumento").val() + "</TipoDocumento>" +
//        "<CantidadProducto>" + $('#tbVentas tbody tr').length + "</CantidadProducto>" +
//        "<CantidadTotal>" + $totalproductos + "</CantidadTotal>" +
//        "<TotalCosto>" + $totalimportes + "</TotalCosto>" +
//        "<ImporteRecibido>" + $("#txtmontopago").val() + "</ImporteRecibido>" +
//        "<ImporteCambio>" + $("#txtcambio").val() + "</ImporteCambio>" +
//        "</VENTA >";

//    DETALLE_CLIENTE = "<DETALLE_CLIENTE><DATOS>" +
//        "<TipoDocumento>" + $("#cboclientetipodocumento").val() + "</TipoDocumento>" +
//        "<NumeroDocumento>" + $("#txtclientedocumento").val() + "</NumeroDocumento>" +
//        "<Nombre>" + $("#txtclientenombres").val() + "</Nombre>" +
//        "<Direccion>" + $("#txtclientedireccion").val() + "</Direccion>" +
//        "<Telefono>" + $("#txtclientetelefono").val() + "</Telefono>" +
//        "</DATOS></DETALLE_CLIENTE>";

//    DETALLE_VENTA = "<DETALLE_VENTA>" + DATOS_VENTA + "</DETALLE_VENTA>";

//    DETALLE = "<DETALLE>" + VENTA + DETALLE_CLIENTE + DETALLE_VENTA + "</DETALLE>"


//    var request = { xml: DETALLE };

//    jQuery.ajax({
//        url: $.MisUrls.url._RegistrarVenta,
//        type: "POST",
//        data: JSON.stringify(request),
//        dataType: "json",
//        contentType: "application/json; charset=utf-8",
//        success: function (data) {

//            $(".card-venta").LoadingOverlay("hide");

//            if (data.estado) {
//                //DOCUMENTO
//                $("#cboventatipodocumento").val("Boleta");

//                //CLIENTE
//                $("#cboclientetipodocumento").val("DNI");
//                $("#txtclientedocumento").val("");
//                $("#txtclientenombres").val("");
//                $("#txtclientedireccion").val("");
//                $("#txtclientetelefono").val("");


//                //PRODUCTO
//                $("#txtIdProducto").val("0");
//                $("#txtproductocodigo").val("");
//                $("#txtproductonombre").val("");
//                $("#txtproductodescripcion").val("");
//                $("#txtproductostock").val("");
//                $("#txtproductoprecio").val("");
//                $("#txtproductocantidad").val("0");

//                //PRECIOS
//                $("#txtsubtotal").val("0");
//                $("#txtigv").val("0");
//                $("#txttotal").val("0");
//                $("#txtmontopago").val("");
//                $("#txtcambio").val("");


//                $("#tbVentas tbody").html("");

           
//                var url = $.MisUrls.url._DocumentoVenta + "?IdVenta=" + data.valor;
//                window.open(url);


//            } else {
//                swal("Mensaje", "No se pudo registrar la venta", "warning")
//            }
//        },
//        error: function (error) {
//            console.log(error)
//            $(".card-venta").LoadingOverlay("hide");
//        },
//        beforeSend: function () {
//            $(".card-venta").LoadingOverlay("show");
//        }
//    });

   

//})

//$('#btnTerminarGuardarVenta2').on('click', function () {

//    var existe_codigo = false;
//    if (


//        parseInt($("#txtCodigoProducto").val()) == 0 ||
//        parseInt($("#txtNombreProducto").val()) == 0 ||
//        parseInt($("#txtNombrePlanta").val()) == 0 ||
//        parseFloat($("#txtUbicacion").val()) == 0 ||
//        parseFloat($("#txtLote").val()) == 0 ||
//        parseFloat($("#txtCantidadProducto").val()) == 0 

//    ) {
//        swal("Mensaje", "Debe completar todos los campos", "warning")
//        return;
//    }

//    $('#tbCompra > tbody  > tr').each(function (index, tr) {
//        var fila = tr;
//        var codigoproducto = $(fila).find("td.codigoproducto").text();

//        if (codigoproducto == $("#txtCodigoProducto").val()) {
//            existe_codigo = true;
//            return false;
//        }

//    });

//    if (!existe_codigo) {
//        $("<tr>").append(
//            $("<td>").append(
//                $("<button>").addClass("btn btn-danger btn-sm").text("Eliminar")
//            ),
//            $("<td>").addClass("codigoproducto").data("idproducto", $("#txtIdProducto").val()).append($("#txtCodigoProducto").val()),
//            $("<td>").addClass("producto").append($("#txtNombreProducto").val()),
//            $("<td>").addClass("planta").append($("#txtNombrePlanta").val()),
//            $("<td>").addClass("ubicacion").append($("#txtUbicacion").val()),
//            $("<td>").addClass("Lote").append($("#txtLote").val()),
//            $("<td>").addClass("cantidad").append($("#txtCantidadProducto").val()),



//        ).appendTo("#tbCompra tbody");

//        $("#txtCodigoProducto").val("")
//        $("#txtNombreProducto").val("")
//        $("#txtNombrePlanta").val("")
//        $("#txtUbicacion").val("")
//        $("#txtLote").val("")
//        $("#txtCantidadProducto").val("")


//    } else {
//        swal("Mensaje", "El producto ya existe en ingresos", "warning")
//    }
//})

function calcularCambio() {
    var montopago = $("#txtmontopago").val().trim() == "" ? 0 : parseFloat($("#txtmontopago").val().trim());
    var totalcosto = parseFloat($("#txttotal").val().trim());
    var cambio = 0;
    cambio = (montopago <= totalcosto ? totalcosto : montopago) - totalcosto;

    $("#txtcambio").val(cambio.toFixed(2));
}

$('#btncalcular').on('click', function () {
    calcularCambio();
})


function calcularPrecios() {
    var subtotal = 0;
    var igv = 0;
    var sumatotal = 0;
    $('#tbVentas > tbody  > tr').each(function (index, tr) {
        var fila = tr;
        var importetotal = parseFloat($(fila).find("td.importetotal").text());
        sumatotal = sumatotal + importetotal;
    });
    igv = sumatotal * 0.18;
    subtotal = sumatotal - igv;


    $("#txtsubtotal").val(subtotal.toFixed(2));
    $("#txtigv").val(igv.toFixed(2));
    $("#txttotal").val(sumatotal.toFixed(2));
}

$('#btnTerminarGuardarVenta').on('click', function () {


    if ($('#tbVentas > tbody  > tr').length == 0) {
        swal("Mensaje", "No existen detalles", "warning")
        return;
    }

    //var $xml = "";
    //var compra = "";
    //var detallecompra = ""
    var detalle = "";
    //var totalcostocompra = 0;

    //$xml = "<DETALLE>";
    //compra = "<COMPRA>" +
    //    "<IdUsuario>!idusuario¡</IdUsuario>" +
    //    "<IdProveedor>" + $("#txtIdProveedor").val() + "</IdProveedor>" +
    //    "<IdTienda>" + $("#txtIdTienda").val() + "</IdTienda>" +
    //    "<TotalCosto>!totalcosto¡</TotalCosto>" +
    //    "</COMPRA>";
    //detallecompra = "<DETALLE_COMPRA>"
 

    var data = Object();
    var dataAll = [];

    $('#tbVentas > tbody  > tr').each(function (index, tr) {

        var fila = tr;
        //var idproducto = parseFloat($(fila).find("td.codigoproducto").data("idproducto"));
        //var cantidad = parseFloat($(fila).find("td.cantidad").text());
        //var preciocompra = parseFloat($(fila).find("td.preciocompra").text());
        //var precioventa = parseFloat($(fila).find("td.precioventa").text());
        //var totalcosto = parseFloat(cantidad) * parseFloat(preciocompra);

        //data.razonsocial = $(fila).find("td.RazonSocial").text();
        //data.paisOrigen = $(fila).find("td.Origen").text();
        data.planta = $(fila).find("td.planta").text();
        data.idProducto = $(fila).find("td.codigoproducto").text();
        //data.producto = $(fila).find("td.producto").text();
        data.cantidad = $(fila).find("td.cantidad").text();
        //data.precio_compra = $(fila).find("td.precio").text();
        //data.numFactura = $(fila).find("td.Factura").text();
        data.lote = $(fila).find("td.Lote").text();
        data.caducidad = $(fila).find("td.fechavencimiento").text();
        data.Ubicacion = $(fila).find("td.ubicacion").text();
      /*  data.isTrabajador = $(fila).find"td.tIdUsuario").text();*/
        /*data.fechaCreacion = $(fila).find("td.ubicacion").text();*/



        //console.log(data);

        dataAll.push(data);

        //console.log(dataAll);

        //detalle = detalle + "<DETALLE>" +
        //    "<IdCompra>0</IdCompra>" +
        //    "<IdProducto>" + idproducto + "</IdProducto>" +
        //    "<Cantidad>" + cantidad + "</Cantidad>" +
        //    "<PrecioUnidadCompra>" + preciocompra + "</PrecioUnidadCompra>" +
        //    "<PrecioUnidadVenta>" + precioventa + "</PrecioUnidadVenta>" +
        //    "<TotalCosto>" + totalcosto.toString() + "</TotalCosto>" +
        //    "</DETALLE>";
        //totalcostocompra = totalcostocompra + totalcosto;


    });

    //console.log(detalle);

    //compra = compra.replace("!totalcosto¡", totalcostocompra.toString());
    //$xml = $xml + compra + detallecompra + detalle + "</DETALLE_COMPRA></DETALLE>";

    //var request = { xml: $xml };

    //alert($.MisUrls.url._GuardarCompra);

    console.log($.MisUrls.url._RegistrarVenta + "?dataAll=" + JSON.stringify(dataAll));

    jQuery.ajax({
        url: $.MisUrls.url._RegistrarVenta+ "?dataAll=" + JSON.stringify(dataAll),
        //url: $.MisUrls.url._GuardarCompra,
        type: "POST",
        //data: JSON.stringify(datall),
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        success: function (data) {
            $.LoadingOverlay("hide");

            if (data.resultado) {

                //PROVEEDOR
                $("#txtIdProveedor").val("0");
                $("#txtRucProveedor").val("");
                $("#txtRazonSocialProveedor").val("");
                $("#txtOrigenProveedor").val("");

                //TIENDA
                $("#txtIdTienda").val("0");
                $("#txtRucTienda").val("");
                $("#txtNombreTienda").val("");

                //PRODUCTO
                $("#txtIdProducto").val("0");
                $("#txtCodigoProducto").val("");
                $("#txtNombreProducto").val("");
                $("#txtCantidadProducto").val("0");
                $("#txtPrecioCompraProducto").val("0");
                $("#txtPrecioVentaProducto").val("0");

                $("#tbVenta tbody").html("");

                swal("Mensaje", "Se registro la compra", "success")
            } else {

                swal("Mensaje", "No se pudo registrar la compra", "warning")
            }
        },
        error: function (error) {
            console.log(error)
        },
        beforeSend: function () {
            $.LoadingOverlay("show");
        },
    });



})


function controlarStock($idproducto, $idtienda, $cantidad, $restar) {
    var request = {
        idproducto: $idproducto,
        idtienda: $idtienda,
        cantidad: $cantidad,
        restar: $restar
    }


    jQuery.ajax({
        url: $.MisUrls.url._ControlarStockProducto,
        type: "POST",
        data: JSON.stringify(request),
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        success: function (data) {
           
        },
        error: function (error) {
            console.log(error)
        },
        beforeSend: function () {
        },
    });

  
}


window.onbeforeunload = function () {
    if ($('#tbVentas tbody tr').length > 0) {

        $('#tbVentas > tbody  > tr').each(function (index, tr) {
            var fila = tr;
            var productocantidad = parseInt($(fila).find("td.productocantidad").text());
            var idproducto = $(fila).find("td.producto").data("idproducto");

            controlarStock(parseInt(idproducto), parseInt($("#txtIdTienda").val()), parseInt(productocantidad), false);
        });
    }
};
