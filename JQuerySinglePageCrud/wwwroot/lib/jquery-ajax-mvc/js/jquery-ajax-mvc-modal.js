var modal;
var settings;

$.fn.AjaxModal = function (options) {
    modal = this;

    settings = $.extend({
        target: $(this).find('.modal-body'),
    }, options);

    if ($(this).attr('ajax-modal-container') != undefined) {
        settings.target = $(this).attr('ajax-modal-container');
    }

    $(modal).on('hidden.bs.modal', function (e) {
        $(settings.target).html('<div style="height: 300px;"></div>');
    })
};

function modalAction(url, target) {
    $(target).append('<div class="spinner-container"></div><div class="spinner-img"><img src="/img/loading.gif" /></div>');

    $.ajax({
        url: url,
        data: [],
        type: 'get'
    }).done(function (result) {
        if (result != null) {
            $(target).html(result);
        }
    }).fail(function (xhr) {
        if (xhr.status == 404) {
            $(target).html(
                '<div class="row text-center m-5">\
                    <i class="fa-solid fa-8x p-5 fa-magnifying-glass"></i>\
                    <h1 class="display-1">Not Found</h1>\
                </div>'
            );
        } else if (xhr.status == 401) {
            $(target).html(
                '<div class="row text-center m-5">\
                    <i class="fa-solid fa-8x p-5 fa-close"></i>\
                    <h1 class="display-1">Unauthorized</h1>\
                </div>'
            );
        } else if (xhr.status == 400) {
            $(target).html(
                '<div class="row text-center m-5">\
                    <i class="fa-solid fa-8x p-5 fa-triangle-exclamation"></i>\
                    <h1 class="display-1">Bad Request</h1>\
                </div>'
            );
        }
    }).always(function () {
        $(modal).modal('show');
    });
}
