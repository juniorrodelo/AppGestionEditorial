function mostrarAtributos(id) {
    if (id == "libros") {
        /* Mostrando Atributos */
        $("#nCapitulos").show();

        /* Añadiendo Atributos */
        $("#ContentPlaceHolder1_txtnCapitulos").attr("required", "required");
        $("#ContentPlaceHolder1_txtnCapitulos").attr("pattern", "^([0-9]){1,}$");

        $("#nTomos").show();

        /* Añadiendo Atributos */
        $("#ContentPlaceHolder1_txtTomos").attr("required", "required");
        $("#ContentPlaceHolder1_txtTomos").attr("pattern", "^([0-9]){1,}$");

        $("#nivel").show();

        /* Ocultando Atributos (Revistas) */
        $("#nVolumenes").hide();

        /* Quitando Atributos */
        $('#ContentPlaceHolder1_txtVolumenes').removeAttr("required", "required");
        $('#ContentPlaceHolder1_txtVolumenes').removeAttr("pattern", "^([0-9]){1,}$");

        $("#nArticulos").hide();

        /* Quitando Atributos */
        $('#ContentPlaceHolder1_txtArticulos').removeAttr("required", "required");
        $('#ContentPlaceHolder1_txtArticulos').removeAttr("pattern", "^([0-9]){1,}$");

        /* Ocultando Atributos (Cientificos) */
        $("#tipo").hide();
        /* Quitando Atributos */
        $('#ContentPlaceHolder1_txtTipo').removeAttr("required", "required");
    }

    if (id == "revistas") {
        /* Mostrando Atributos */
        $("#nVolumenes").show();
        /* Añadiendo Atributos */
        $("#ContentPlaceHolder1_txtVolumenes").attr("required", "required");
        $("#ContentPlaceHolder1_txtVolumenes").attr("pattern", "^([0-9]){1,}$");

        $("#nArticulos").show();
        /* Añadiendo Atributos */
        $("#ContentPlaceHolder1_txtArticulos").attr("required", "required");
        $("#ContentPlaceHolder1_txtArticulos").attr("pattern", "^([0-9]){1,}$");


        /* Ocultando Atributos (Revistas) */
        $("#tipo").hide();
        /* Quitando Atributos */
        $('#ContentPlaceHolder1_txtTipo').removeAttr("required", "required");


        /* Quitando Atributos */
        $('#ContentPlaceHolder1_txtTipo').removeAttr("required", "required");

        /* Ocultando Atributos (Libros) */
        $("#nCapitulos").hide();
            /* Quitando Atributos */
            $('#ContentPlaceHolder1_txtnCapitulos').removeAttr("required", "required");
            $('#ContentPlaceHolder1_txtnCapitulos').removeAttr("pattern", "^([0-9]){1,}$");


        $("#nTomos").hide();
             /* Quitando Atributos */
        $('#ContentPlaceHolder1_txtTomos').removeAttr("required", "required");
        $('#ContentPlaceHolder1_txtTomos').removeAttr("pattern", "^([0-9]){1,}$");
        $("#nivel").hide();
    }


    if (id == "cientificos") {
        /* Mostrando Atributos */
        $("#tipo").show();
        /* Añadiendo Atributos */
        $('#ContentPlaceHolder1_txtTipo').attr("required", "required");

        /* Ocultando Atributos (Revistas) */
        $("#nVolumenes").hide();
        /* Quitando Atributos */
        $('#ContentPlaceHolder1_txtVolumenes').removeAttr("required", "required");
        $('#ContentPlaceHolder1_txtVolumenes').removeAttr("pattern", "^([0-9]){1,}$");


        $("#nArticulos").hide();
        /* Quitando Atributos */
        $('#ContentPlaceHolder1_txtArticulos').removeAttr("required", "required");
        $('#ContentPlaceHolder1_txtArticulos').removeAttr("pattern", "^([0-9]){1,}$");

        /* Ocultando Atributos (Libros) */        
        $("#nCapitulos").hide();
        /* Quitando Atributos */
        $('#ContentPlaceHolder1_txtnCapitulos').removeAttr("required", "required");
        $('#ContentPlaceHolder1_txtnCapitulos').removeAttr("pattern", "^([0-9]){1,}$");

        $("#nTomos").hide();
        /* Quitando Atributos */
        $('#ContentPlaceHolder1_txtTomos').removeAttr("required", "required");
        $('#ContentPlaceHolder1_txtTomos').removeAttr("pattern", "^([0-9]){1,}$");

        $("#nivel").hide();
    }

    if (id == "otros") {
        /* Ocultando Atributos (Cientificos) */
        $("#tipo").hide();
        /* Quitando Atributos */
        $('#ContentPlaceHolder1_txtTipo').removeAttr("required", "required");

        /* Ocultando Atributos (Revistas) */
        $("#nVolumenes").hide();
        /* Quitando Atributos */
        $('#ContentPlaceHolder1_txtVolumenes').removeAttr("required", "required");
        $('#ContentPlaceHolder1_txtVolumenes').removeAttr("pattern", "^([0-9]){1,}$");

        $("#nArticulos").hide();
        /* Quitando Atributos */
        $('#ContentPlaceHolder1_txtArticulos').removeAttr("required", "required");
        $('#ContentPlaceHolder1_txtArticulos').removeAttr("pattern", "^([0-9]){1,}$");

        /* Ocultando Atributos (Libros) */
        $("#nCapitulos").hide();
        /* Quitando Atributos */
        $('#ContentPlaceHolder1_txtnCapitulos').removeAttr("required", "required");
        $('#ContentPlaceHolder1_txtnCapitulos').removeAttr("pattern", "^([0-9]){1,}$");

        $("#nTomos").hide();
        /* Quitando Atributos */
        $('#ContentPlaceHolder1_txtTomos').removeAttr("required", "required");
        $('#ContentPlaceHolder1_txtTomos').removeAttr("pattern", "^([0-9]){1,}$");
        $("#nivel").hide();
    }

}


function mostrarPermisos(id) {
    if (id == "digital") {
        /* Quitando Permisos */
        $('#ContentPlaceHolder1_chEscuchar').attr('disabled', true);
        $('#ContentPlaceHolder1_chVisualizar').attr('disabled', true);

        /* Devolviendo Permisos */
        $('#ContentPlaceHolder1_chLeer').removeAttr('disabled', true);
        $('#ContentPlaceHolder1_chGuardar').removeAttr('disabled', true);
        $('#ContentPlaceHolder1_chImprimir').removeAttr('disabled', true);
        $('#ContentPlaceHolder1_chEditar').removeAttr('disabled', true);
    }

    if (id == "impreso") {
        /* Quitando Permisos */
        $('#ContentPlaceHolder1_chLeer').attr('disabled', true);
        $('#ContentPlaceHolder1_chGuardar').attr('disabled', true);
        $('#ContentPlaceHolder1_chImprimir').attr('disabled', true);
        $('#ContentPlaceHolder1_chEditar').attr('disabled', true);
        $('#ContentPlaceHolder1_chEscuchar').attr('disabled', true);
        $('#ContentPlaceHolder1_chVisualizar').attr('disabled', true);
    }

    if (id == "multimedia") {
        /* Quitando Permisos */
        $('#ContentPlaceHolder1_chLeer').attr('disabled', true);
        $('#ContentPlaceHolder1_chImprimir').attr('disabled', true);
        $('#ContentPlaceHolder1_chEditar').attr('disabled', true);

        /* Devolviendo Permisos */
        $('#ContentPlaceHolder1_chVisualizar').removeAttr('disabled', true);
        $('#ContentPlaceHolder1_chEscuchar').removeAttr('disabled', true);
        $('#ContentPlaceHolder1_chGuardar').removeAttr('disabled', true);
    }

}