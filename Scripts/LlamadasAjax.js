function SendAjax(url, data, type = "POST", showLog = false) {

    var e;

    $.ajax({
        type: type,
        url: url,
        data: data,
        async: false,
        cache: false,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            alert('Esta llamada no funciona, reporta con el administrador');
            e = new EResultado("error", true, XMLHttpRequest);
        },
        success: function (response) {
            e = new EResultado("Ok", false, response.d);
        }
    });
    if (showLog)
        console.log(e);

    return e;
}

function EResultado(message, error, data) {

    this.message = message;
    this.error = error;
    this.data = data;

    this.setData = function (message, error, data) {
        this.message = message;
        this.error = error;
        this.data = data;
    }


    this.IsSuccess = function () {
        return !this.error;
    }
}