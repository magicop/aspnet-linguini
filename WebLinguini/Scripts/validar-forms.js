
var $ = jQuery.noConflict();
jQuery(document).ready(function ($) {

    jQuery.noConflict();
    //$.validator.addMethod('validatenew', function () {
    //    return ($('#codigoProductoOld').val() != $('#codigoProductoNew').val())
    //}, "El código de producto antiguo no puede ser el mismo que el nuevo.");

    //VALIDACIONES $.VALIDATE
    $.extend($.validator.messages, {
        required: "Este campo es obligatorio.",
        remote: "Por favor, rellena este campo.",
        email: "Por favor, escribe una dirección de correo válida",
        url: "Por favor, escribe una URL válida.",
        date: "Por favor, escribe una fecha válida.",
        dateISO: "Por favor, escribe una fecha (ISO) válida.",
        number: "Por favor, escribe un número entero válido.",
        digits: "Por favor, escribe sólo dígitos.",
        creditcard: "Por favor, escribe un número de tarjeta válido.",
        equalTo: "Por favor, escribe el mismo valor de nuevo.",
        accept: "Ingrese una imagen, pdf o word",
        maxlength: $.validator.format("Por favor, no escribas más de {0} caracteres."),
        minlength: $.validator.format("Por favor, no escribas menos de {0} caracteres."),
        rangelength: $.validator.format("Por favor, escribe un valor entre {0} y {1} caracteres."),
        range: $.validator.format("Por favor, escribe un valor entre {0} y {1}."),
        max: $.validator.format("Por favor, escribe un valor menor o igual a {0}."),
        min: $.validator.format("Por favor, escribe un valor mayor o igual a {0}.")
    });

    jQuery(document).off("click");
    jQuery(document).on("click", "#btnAgregarCarta", function (e) {

        $.validator.setDefaults({
            debug: true,
            success: "valid"
        });

        $form = $("#FormAgregarCarta");

        $form.validate({
            submitHandler: function ($form) {
                $("error").addClass("alert alert-primary");
                $form.submit();
            },
            rules: {
                nombreCarta: {
                    required: true,
                    minlength: 3,
                    maxlength: 25
                },
                valorCarta: {
                    required: true,
                    minlength: 3,
                    maxlength: 9,
                    number: true
                },
                idCategoria: {
                    required: true
                },
                imagenCarta: {
                    required: true
                }


            },
            messages: {
                nombreCarta: {
                    required: "Debe ingresar el nombre de la carta",
                    minlength: "El nombre de la carta debe ser mayor a {0} digitos",
                    maxlength: "El nombre de la carta debe ser menor a {0} digitos",
                },
                valorCarta: {
                    required: "Debe ingresar el valor de la carta",
                    minlength: "El valor de la carta debe ser mayor a {0} digitos",
                    maxlength: "El valor de la carta debe ser menor a {0} digitos",
                    number: "Solamente puede escribir números"
                },
                idCategoria: {
                    required: "Debe seleccionar la categoria correspondiente"
                },
                imagenCarta: {
                    required: "Debe ingresar un url de imagen para la carta"
                }
            },
            errorElement: 'div',
            errorLabelContainer: '.errorTxt'
        });
    });

    jQuery(document).on("click", "#btnBuscarCarta", function (e) {


        $.validator.setDefaults({
            debug: true,
            success: "valid"
        });

        $form = $("#FormBuscarCarta");

        $form.validate({
            submitHandler: function ($form) {
                //$("body").addClass("loading");
                $form.submit();
            },
            rules: {
                idCarta: {
                    required: true
                }
            },
            messages: {
                idCarta: {
                    required: "Debe elegir un número de carta correspondiente"
                }

            },
            errorElement: 'div',
            errorLabelContainer: '.errorTxt'
        });
    });

    jQuery(document).on("click", "#btnLogin", function (e) {


        $.validator.setDefaults({
            debug: true,
            success: "valid"
        });

        $form = $("#FormLogin");

        $form.validate({
            submitHandler: function ($form) {
                //$("body").addClass("loading");
                $form.submit();
            },
            rules: {
                username: {
                    required: true,
                    maxlength: 16
                },
                password: {
                    required: true,
                    maxlength: 16
                }
            },
            messages: {
                username: {
                    required: "Debe ingresar el usuario",
                    maxlength: "El usuario ingresado no debe superar los {0} caracteres"
                },
                password: {
                    required: "Debe ingresar la password",
                    maxlength: "La password ingresada no debe superar los {0} caracteres"
                }

            },
            errorElement: 'div',
            errorLabelContainer: '.errorTxt'
        });
    });

    jQuery(document).on("click", "#btnAgregarComprobante", function (e) {


        $.validator.setDefaults({
            debug: true,
            success: "valid"
        });

        $form = $("#FormAgregarComprobante");

        $form.validate({
            submitHandler: function ($form) {
                //$("body").addClass("loading");
                $form.submit();
            },
            rules: {
                totalComprobante: {
                    required: true,
                    minlength: 3,
                    maxlength: 10,
                    number: true
                },
                idTipoPago: {
                    required: true
                }
            },
            messages: {
                totalComprobante: {
                    required: "Debe ingresar el total del comprobante",
                    minlength: "El total ingresado debe ser mayor a {0} caracteres",
                    maxlength: "El total ingresado debe ser menor a {0} caracteres",
                    number: "Solamente puedes escribir números"
                },
                idTipoPago: {
                    required: "Debe ingresar el tipo de pago correspondiente"
                }

            },
            errorElement: 'div',
            errorLabelContainer: '.errorTxt'
        });
    });

    jQuery(document).on("click", "#btnBuscarComprobante", function (e) {


        $.validator.setDefaults({
            debug: true,
            success: "valid"
        });

        $form = $("#FormBuscarComprobante");

        $form.validate({
            submitHandler: function ($form) {
                //$("body").addClass("loading");
                $form.submit();
            },
            rules: {
                idComprobante: {
                    required: true
                }
            },
            messages: {
                idComprobante: {
                    required: "Debe ingresar el id del comprobante"
                }
            },
            errorElement: 'div',
            errorLabelContainer: '.errorTxt'
        });
    });

    jQuery(document).on("click", "#btnBuscarMesa", function (e) {


        $.validator.setDefaults({
            debug: true,
            success: "valid"
        });

        $form = $("#FormBuscarMesa");

        $form.validate({
            submitHandler: function ($form) {
                //$("body").addClass("loading");
                $form.submit();
            },
            rules: {
                idMesa: {
                    required: true
                }
            },
            messages: {
                idMesa: {
                    required: "Debe ingresar el id de la mesa"
                }

            },
            errorElement: 'div',
            errorLabelContainer: '.errorTxt'
        });
    });

    jQuery(document).on("click", "#btnBuscarOrden", function (e) {


        $.validator.setDefaults({
            debug: true,
            success: "valid"
        });

        $form = $("#FormBuscarOrden");

        $form.validate({
            submitHandler: function ($form) {
                //$("body").addClass("loading");
                $form.submit();
            },
            rules: {
                idOrden: {
                    required: true
                }
            },
            messages: {
                idOrden: {
                    required: "Debe ingresar el id de la orden"
                }
            },
            errorElement: 'div',
            errorLabelContainer: '.errorTxt'
        });
    });

    jQuery(document).on("click", "#btnBuscarPedProv", function (e) {


        $.validator.setDefaults({
            debug: true,
            success: "valid"
        });

        $form = $("#FormBuscarPedProv");

        $form.validate({
            submitHandler: function ($form) {
                //$("body").addClass("loading");
                $form.submit();
            },
            rules: {
                idPedidoProveedor: {
                    required: true
                }
            },
            messages: {
                idPedidoProveedor: {
                    required: "Debe ingresar el pedido de proveedor correspondiente"
                }
            },
            errorElement: 'div',
            errorLabelContainer: '.errorTxt'
        });
    });

    jQuery(document).on("click", "#btnBuscarSolProv", function (e) {


        $.validator.setDefaults({
            debug: true,
            success: "valid"
        });

        $form = $("#FormBuscarSolProv");

        $form.validate({
            submitHandler: function ($form) {
                //$("body").addClass("loading");
                $form.submit();
            },
            rules: {
                idSolicitudProveedor: {
                    required: true
                }
            },
            messages: {
                idSolicitudProveedor: {
                    required: "Debe ingresar la solicitud de proveedor correspondiente"
                }
            },
            errorElement: 'div',
            errorLabelContainer: '.errorTxt'
        });
    });

    jQuery(document).on("click", "#btnBuscarProveedor", function (e) {


        $.validator.setDefaults({
            debug: true,
            success: "valid"
        });

        $form = $("#FormBuscarProveedor");

        $form.validate({
            submitHandler: function ($form) {
                //$("body").addClass("loading");
                $form.submit();
            },
            rules: {
                idProveedor: {
                    required: true
                }
            },
            messages: {
                idProveedor: {
                    required: "Debe ingresar el proveedor correspondiente"
                }
            },
            errorElement: 'div',
            errorLabelContainer: '.errorTxt'
        });
    });

    jQuery(document).on("click", "#btnAgregarCarta", function (e) {


        $.validator.setDefaults({
            debug: true,
            success: "valid"
        });

        $form = $("#FormAgregarCarta");

        $form.validate({
            submitHandler: function ($form) {
                //$("body").addClass("loading");
                $form.submit();
            },
            rules: {
                nombreCarta: {
                    required: true
                },
                valorCarta: {
                    required: true,
                    number: true,
                    minlength: 3,
                    maxlength: 9
                },
                idCategoria: {
                    required: true
                },
                imagenCarta: {
                    required: true
                }
            },
            messages: {
                nombreCarta: {
                    required: "Debe ingresar el nombre"
                },
                valorCarta: {
                    required: "Debe ingresar el valor",
                    number: "Debe ingresar números",
                    minlength: "El valor de carta debe ser mayor a {0} caracteres",
                    maxlength: "El valor de carta debe ser menor a {0} caracteres"
                },
                idCategoria: {
                    required: "Debe ingresar la categoria"
                },
                imagenCarta: {
                    required: "Debe ingresar el url de la imagen"
                }
            },
            errorElement: 'div',
            errorLabelContainer: '.errorTxt'
        });
    });

    jQuery(document).on("click", "#btnAgregarPedProv", function (e) {


        $.validator.setDefaults({
            debug: true,
            success: "valid"
        });

        $form = $("#FormAgregarPedProv");

        $form.validate({
            submitHandler: function ($form) {
                //$("body").addClass("loading");
                $form.submit();
            },
            rules: {
                ordenCompra: {
                    required: true
                },
                idEmpleado: {
                    required: true
                },
                idProducto: {
                    required: true
                },
                idProveedor: {
                    required: true
                },
                cantidadSolicitud: {
                    required: true,
                    number: true,
                    minlength: 4,
                    maxlength: 10
                },
                valorDetalleSolicitud: {
                    required: true,
                    number: true,
                    minlength: 4,
                    maxlength: 10
                }
            },
            messages: {
                ordenCompra: {
                    required: "Debe ingresar la orden de compra"
                },
                idEmpleado: {
                    required: "Debe ingresar el id del empleado"
                },
                idProducto: {
                    required: "Debe ingresar el id del producto"
                },
                idProveedor: {
                    required: "Debe ingresar el id del proveedor"
                },
                cantidadSolicitud: {
                    required: "Debe ingresar la cantidad de la solicitud",
                    number: "Debe ingresar un número",
                    minlength: "La cantidad de la solicitud debe ser mayor a {0} caracteres",
                    maxlength: "La cantidad de la solicitud debe ser menor a {0} caracteres"
                },
                valorDetalleSolicitud: {
                    required: "Debe ingresar el valor del detalle",
                    number: "Debe ingresar números",
                    minlength: "El valor del detalle debe ser mayor a {0} caracteres",
                    maxlength: "El valor del detalle debe ser menor a {0} caracteres"
                }
            },
            errorElement: 'div',
            errorLabelContainer: '.errorTxt'
        });
    });
});