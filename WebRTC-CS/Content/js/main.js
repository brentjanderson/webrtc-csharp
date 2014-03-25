/*jslint browser: true */
/*global $:false */
/*properties
    pageTitle, promptTimer, toggleClass
*/
App = {};

(function () {
    "use strict";

    App.pageTitle = 'IS 542';

    App.promptTimer = function () {
        setTimeout(function () {
            $('.dialog').show().toggleClass('visible');
        }, 10 * 1000);
    };

    App.promptTimer();

    // Setup some JQuery magic!
    $('#accordion').accordion();

}());
