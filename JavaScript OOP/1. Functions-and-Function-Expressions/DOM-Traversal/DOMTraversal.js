/**
 * Created by Zhivko on 29.10.2014 г..
 */

function traverse(selector) {
    'use strict';

    var element,
        elementAsString;

    element = document.querySelector(selector);
    traverseElement(element, '');

    function traverseElement(element, spacing) {

        spacing = spacing || "    ";
        elementAsString = spacing + element.nodeName.toLowerCase() + ':';

        if (element.hasAttribute('id')) {
            elementAsString += ' id="' + element.id;
        }
        if (element.hasAttribute('class')) {
            elementAsString += ' class="' + element.className + '"';
        }
        console.log(elementAsString);

        [].forEach.call(element.childNodes, function (child) {
            if (child.nodeType === 1) {
                traverseElement(child, spacing + "    ");
            }
        });
    }
}

var selector = ".birds";
traverse(selector);
