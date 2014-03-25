/*jslint browser: true */
/*global $:false,App:false*/
/*properties
    appendTo, click, get, getElementsByTagName, href, location, pageTitle,
    promptTimer, text, toggleClass
*/

$(function () {
    "use strict";

    $.get('/Content/templates/dialog.html', function (d) {
        $(d).appendTo('body').hide();

        $('.dialog button[data-evt="extend"]').click(function () {
            $('.dialog').toggleClass('visible').hide();
            App.promptTimer();
        });

        $('.dialog button[data-evt="end"]').click(function () {
            window.location.href = 'https://www.google.com';
        });
    });
});
