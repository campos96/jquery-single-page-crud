$.fn.AjaxForm = function (options) {

    var settings = $.extend({
        target: $(this).parent()
    }, options);

    $(this).submit(function (event) {

        var form = $(this);

        if ($(this).valid()) {
            $(settings.target).append('<div class="spinner-container"></div><div class="spinner-img"><img src="/img/loading.gif" /></div>');
            $.ajax({
                url: form[0].action,
                data: form.serializeArray(),
                type: form[0].method
            }).done(function (result) {
                if (result != null) {
                    $(settings.target).html(result);
                }
            }).fail(function (xhr) {
                if (xhr.status == 404) {
                    $(settings.target).html(
                        '<div class="row text-center m-5">\
                            <i class="fa-solid fa-8x p-5 fa-magnifying-glass"></i>\
                            <h1 class="display-1">Not Found</h1>\
                        </div>'
                    );
                } else if (xhr.status == 401) {
                    $(settings.target).html(
                        '<div class="row text-center m-5">\
                            <i class="fa-solid fa-8x p-5 fa-close"></i>\
                            <h1 class="display-1">Unauthorized</h1>\
                        </div>'
                    );
                } else if (xhr.status == 400) {
                    $(settings.target).html(
                        '<div class="row text-center m-5">\
                            <i class="fa-solid fa-8x p-5 fa-triangle-exclamation"></i>\
                            <h1 class="display-1">Bad Request</h1>\
                        </div>'
                    );
                }
            });
        }

        event.preventDefault();
    });
};