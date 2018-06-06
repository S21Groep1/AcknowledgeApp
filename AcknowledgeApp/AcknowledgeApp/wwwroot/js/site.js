//var language = {
//    'nl': {
//        'actiepunten': 'Actiepunten',
//        'STARR': 'STARR',
//        'mijnaccount' : 'Mijn Account',
//        'loguit' : 'Log Uit'
//    },
//    'en': {
//        'actiepunten': 'Actionpoints',
//        'STARR': 'STARR',
//        'mijnaccount': 'My Account',
//        'loguit': 'Log Out'
//    }
//}
//$(function () {
//    $('.translate').click.(function () {
//        var lang = $(this).attr('id');

//        $('.lang').each(function (index, element) {
//            $('this').text(language[lang][$(this).attr('key')]);
//        });
//    });
//})
var dictionary = {
    'actiepunten': {
        'nl': 'Actiepunten',
        'en': 'Actionpoints',
    }
};
var langs = ['it', 'en', 'fr'];
var current_lang_index = 0;
var current_lang = langs[current_lang_index];

window.change_lang = function () {
    current_lang_index = ++current_lang_index % 3;
    current_lang = langs[current_lang_index];
    translate();
}

function translate() {
    $("[data-translate]").each(function () {
        var key = $(this).data('translate');
        $(this).html(dictionary[key][current_lang] || "N/A");
    });
}

translate();
