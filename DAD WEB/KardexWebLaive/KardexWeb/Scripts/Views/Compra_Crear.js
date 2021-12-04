

var tabladata;
var tablaproveedor;
var tablaPlanta;
var tablaproducto;
var tablaUbicacion;


$(document).ready(function () {
    activarMenu("Compras");


    
    //OBTENER PROVEEDORES
    tablaproveedor = $('#tbProveedor').DataTable({
        "ajax": {
            "url": $.MisUrls.url._ObtenerProveedores,
            "type": "GET",
            "datatype": "json"
        },
        "columns": [
            {
                "data": "idProveedor", "render": function (data, type, row, meta) {
                    return "<button class='btn btn-sm btn-primary ml-2' type='button' onclick='proveedorSelect(" + JSON.stringify(row) + ")'><i class='fas fa-check'></i></button>"
                },
                "orderable": false,
                "searchable": false,
                "width": "90px"
            },
            { "data": "rucProveedor" },
            { "data": "razonSocial" },
            { "data": "pais" },
            { "data": "direccion" }
            
        ],
        "language": {
            "url": $.MisUrls.url.Url_datatable_spanish
        },
        responsive: true
    });

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

    //OBTENER UBICACION
    tablaUbicacion = $('#tbUbicacion').DataTable({
        "ajax": {
            "url": $.MisUrls.url._ObtenerUbicacion,
            "type": "GET",
            "datatype": "json"
        },
        "columns": [
            {
                "data": "idUbicacion", "render": function (data, type, row, meta) {
                    return "<button class='btn btn-sm btn-primary ml-2' type='button' onclick='UbicacionSelect(" + JSON.stringify(row) + ")'><i class='fas fa-check'></i></button>"
                },
                "orderable": false,
                "searchable": false,
                "width": "90px"
            },
            { "data": "idUbicacion" },
            { "data": "seccion" },
            //{ "data": "Direccion" }

        ],
        "language": {
            "url": $.MisUrls.url.Url_datatable_spanish
        },
        responsive: true
    });

    //OBTENER PRODUCTOS
    tablaproducto = $('#tbProducto').DataTable({
        "ajax": {
            /*"url": $.MisUrls.url._ObtenerProductosPorTienda + "?IdTienda=0",*/
            "url": $.MisUrls.url._ObtenerProductosPorTienda,
            "type": "GET",
            "datatype": "json"
        },
        "columns": [
            {
                "data": "idProducto", "render": function (data, type, row, meta) {
                    return "<button class='btn btn-sm btn-primary ml-2' type='button' onclick='productoSelect(" + JSON.stringify(row) + ")'><i class='fas fa-check'></i></button>"
                },
                "orderable": false,
                "searchable": false,
                "width": "90px"
            },
            { "data": "idProducto" },
            { "data": "descripcion" },
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

})

function buscarProveedor() {
    /*alert(1);*/
    tablaproveedor.ajax.reload();
    $('#modalProveedor').modal('show');
}


function buscarPlanta() {
    tablaPlanta.ajax.reload();
    $('#modalTienda').modal('show');
}

function buscarUbicacion() {
    tablaUbicacion.ajax.reload();
    $('#modalUbicacion').modal('show');
}

function buscarProducto() {

    //alert(1);
    //if (parseInt($("#txtIdTienda").val()) == 0) {
    //    swal("Mensaje", "Debe seleccionar una tienda primero", "warning")
    //    return;
    //}
    /*tablaproducto.ajax.url($.MisUrls.url._ObtenerProductosPorTienda + "?IdTienda=" + $("#txtIdTienda").val()).load();*/
    tablaproducto.ajax.reload();

    $('#modalProducto').modal('show');
}

function proveedorSelect(json) {

    $("#txtIdProveedor").val(json.idProveedor);
    $("#txtRucProveedor").val(json.rucProveedor);
    $("#txtRazonSocialProveedor").val(json.razonSocial);
    $("#txtOrigenProveedor").val(json.pais);

    $('#modalProveedor').modal('hide');
}

function tiendaSelect(json) {
    //$("#txtIdTienda").val(json.IdTienda);
    $("#txtNombrePlanta").val(json.nombreArea);
    //$("#txtNombreTienda").val(json.Nombre);

    $('#modalTienda').modal('hide');
}

function UbicacionSelect(json) {
    //$("#txtIdTienda").val(json.IdTienda);
    $("#txtUbicacion").val(json.seccion);
    //$("#txtNombreTienda").val(json.Nombre);

    $('#modalUbicacion').modal('hide');
}

function productoSelect(json) {
    $("#txtIdProducto").val(json.idProducto);
    $("#txtCodigoProducto").val(json.idProducto);
    $("#txtNombreProducto").val(json.descripcion);

    $('#modalProducto').modal('hide');
}



$("#txtCodigoProducto").on('keypress', function (e) {

    if (e.which == 13) {
        
        //OBTENER PRODUCTOS
        jQuery.ajax({
            url: $.MisUrls.url._ObtenerProductos,
            type: "GET",
            dataType: "json",
            contentType: "application/json; charset=utf-8",
            success: function (data) {
                $("#txtCodigoProducto").LoadingOverlay("hide");
                var encontrado = false;
                if (data.data != null) {
                    $.each(data.data, function (i, item) {
                        if (item.Activo == true && item.Codigo == $("#txtCodigoProducto").val()) {

                            $("#txtIdProducto").val(item.IdProducto);
                            $("#txtCodigoProducto").val(item.Codigo);
                            $("#txtNombreProducto").val(item.Nombre);

                            encontrado = true;
                            return false;
                        }
                    })

                    if (!encontrado) {
                        $("#txtIdProducto").val("0");
                        $("#txtNombreProducto").val("");
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

$("#txtCantidadProducto").inputFilter(function (value) {
    return /^-?\d*$/.test(value);
});

$("#txtPrecioCompraProducto").inputFilter(function (value) {
    return /^-?\d*[.]?\d{0,2}$/.test(value);
});

$("#txtPrecioVentaProducto").inputFilter(function (value) {
    return /^-?\d*[.]?\d{0,2}$/.test(value);
});



$('#btnAgregarCompra').on('click', function () {

    var existe_codigo = false;
    if (
        parseInt($("#txtRucProveedor").val()) == 0 ||
        parseInt($("#txtOrigenProveedor").val()) == 0 ||
        parseInt($("#txtNombrePlanta").val()) == 0 ||
        parseInt($("#txtCodigoProducto").val()) == 0 ||
        parseInt($("#txtNombreProducto").val()) == 0 ||
        parseFloat($("#txtCantidadProducto").val()) == 0 ||
        parseFloat($("#txtPrecioProducto").val()) == 0 ||
        parseFloat($("#txtFactura").val()) == 0 ||
        parseFloat($("#txtLote").val()) == 0 ||
        parseFloat($("#txtFechaVencimiento").val()) == 0 ||
        parseFloat($("#txtUbicacion").val()) == 0 
        
    ) {
        swal("Mensaje", "Debe completar todos los campos", "warning")
        return;
    }

    $('#tbCompra > tbody  > tr').each(function (index, tr) {
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
            $("<td>").addClass("RazonSocial").append($("#txtRazonSocialProveedor").val()),
            $("<td>").addClass("Origen").append($("#txtOrigenProveedor").val()),
            $("<td>").addClass("planta").append($("#txtNombrePlanta").val()),
            $("<td>").addClass("codigoproducto").data("idproducto", $("#txtIdProducto").val()).append($("#txtCodigoProducto").val()),
            $("<td>").addClass("producto").append($("#txtNombreProducto").val()),
            $("<td>").addClass("cantidad").append($("#txtCantidadProducto").val()),
            $("<td>").addClass("precio").append($("#txtPrecioProducto").val()),
            $("<td>").addClass("Factura").append($("#txtFactura").val()),
            $("<td>").addClass("Lote").append($("#txtLote").val()),
            $("<td>").addClass("fechavencimiento").append($("#txtFechaVencimiento").val()),
            $("<td>").addClass("ubicacion").append($("#txtUbicacion").val()),



        ).appendTo("#tbCompra tbody");
        $("#txtRucProveedor").val("")
        $("#txtRazonSocialProveedor").val("")
        $("#txtOrigenProveedor").val("")
        $("#txtNombrePlanta").val("")
        $("#txtCodigoProducto").val("")
        $("#txtNombreProducto").val("")
        $("#txtCantidadProducto").val("")
        $("#txtPrecioProducto").val("")
        $("#txtFactura").val("")
        $("#txtLote").val("")
        $("#txtFechaVencimiento").val("")
        $("#txtUbicacion").val("")

    } else {
        swal("Mensaje", "El producto ya existe en ingresos", "warning")
    }
})

$('#tbCompra tbody').on('click', 'button[class="btn btn-danger btn-sm"]', function () {
    $(this).parents("tr").remove();
})



$('#btnTerminarGuardarCompra').on('click', function () {


    if ($('#tbCompra > tbody  > tr').length == 0) {
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

    $('#tbCompra > tbody  > tr').each(function (index, tr) {

        var fila = tr;
        //var idproducto = parseFloat($(fila).find("td.codigoproducto").data("idproducto"));
        //var cantidad = parseFloat($(fila).find("td.cantidad").text());
        //var preciocompra = parseFloat($(fila).find("td.preciocompra").text());
        //var precioventa = parseFloat($(fila).find("td.precioventa").text());
        //var totalcosto = parseFloat(cantidad) * parseFloat(preciocompra);

        data.razonsocial = $(fila).find("td.RazonSocial").text();
        data.paisOrigen = $(fila).find("td.Origen").text();
        data.planta = $(fila).find("td.planta").text();
        data.idProducto = $(fila).find("td.codigoproducto").text();
        //data.producto = $(fila).find("td.producto").text();
        data.cantidad = $(fila).find("td.cantidad").text();
        data.precio_compra = $(fila).find("td.precio").text();
        data.numFactura = $(fila).find("td.Factura").text();
        data.lote = $(fila).find("td.Lote").text();
        data.caducidad = $(fila).find("td.fechavencimiento").text();
        data.Ubicacion = $(fila).find("td.ubicacion").text();
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

    console.log($.MisUrls.url._GuardarCompra + "?dataAll=" + JSON.stringify(dataAll));

    jQuery.ajax({
        url: $.MisUrls.url._GuardarCompra + "?dataAll=" + JSON.stringify(dataAll),
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

                $("#tbCompra tbody").html("");

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
