function soloNumeros(evt)
{

    var key = (evt.which) ? evt.which : evt.keyCode;
    //alert(key);
    //var key = window.event ? e.which : e.keyCode;
    if ((key < 48 || key > 57) && ( key != 8 &&  key != 9 ))
    {
        evt.preventDefault();
    }
}
