
//2108_11-26 cambio soloDecimal2 a soloDecimal, para uniformizar la funcion
function soloDecimal(obj, evt) {
    var charCode = (evt.which) ? evt.which : event.keyCode
    var value = obj.value;
    var dotcontains = value.indexOf(".") != -1;
    if (dotcontains)
        if (charCode == 46) return false;
    if (charCode == 46) return true;
    if (charCode > 31 && (charCode < 48 || charCode > 57))
        return false;
    return true;
};

//2018-11-23 rcs Solo permite valores entero sin el punto decimal
function soloEntero(evt) {

    var key = (evt.which) ? evt.which : evt.keyCode;
    if ((key < 48 || key > 57) && (key != 8 && key != 9)) {
        evt.preventDefault();
    }
};

//2018-11-26 rcs convertir mayusculas
function fMayuscula(e) {
    e.value = e.value.toUpperCase();
};
function soloNumeros(evt) {

    var key = (evt.which) ? evt.which : evt.keyCode;
    //alert(key);
    //var key = window.event ? e.which : e.keyCode;
    //rcs if ((key < 48 || key > 57) && (key != 8 && key != 9)) {
    if ((key < 48 || key > 57) && (key != 8 && key != 9) && (key != 46) && (key != 44)) {
        evt.preventDefault();
    }
};
//2018-11-23 rcs Solo permite valores decimales incluye el punto decimal
//2108_11-26 cambio soloDecimal a soloDecimal_rcs, el que queda es soloDecimal2
function soloDecimalrcs(evt) {

    var key = (evt.which) ? evt.which : evt.keyCode;
    //alert(key);
    if ((key < 48 || key > 57) && (key != 8 && key != 9) && (key != 46)) {
        evt.preventDefault();
    }
};

//2018-11-23 rcs encontrado en la logica de RegistroTarifa.cshmt, es mas completo, con esto solo puede ingresar un punto decimal
function validateFloatKeyPress(obj, evt) {
    var charCode = (evt.which) ? evt.which : event.keyCode
    var value = obj.value;
    var dotcontains = value.indexOf(".") != -1;
    if (dotcontains)
        if (charCode == 46) return false;
    if (charCode == 46) return true;
    if (charCode > 31 && (charCode < 48 || charCode > 57))
        return false;
    return true;
};

//2018-11-23 rcs encontrado en la logica de RegistroTarifacshmt, es mas completo, con esto solo puede ingresar un punto decimal
//renombrado a soloDecimal2
//2018-11-26 luego que se cambie la parte de administracion/contratos/tarifas soloDecimal2 a soloDecimal, se borra
function soloDecimal2(obj, evt) {
    var charCode = (evt.which) ? evt.which : event.keyCode
    var value = obj.value;
    var dotcontains = value.indexOf(".") != -1;
    if (dotcontains)
        if (charCode == 46) return false;
    if (charCode == 46) return true;
    if (charCode > 31 && (charCode < 48 || charCode > 57))
        return false;
    return true;
};
