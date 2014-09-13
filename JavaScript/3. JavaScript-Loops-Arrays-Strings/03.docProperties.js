/**
 * Created by Zhivko on 21.7.2014 г..
 */
function displayProperties() {
    var docProperties = [],
        property;

    for (property in document) {
        docProperties.push(property);
    }

    docProperties.sort();
    console.info(docProperties.join('\n'));
}

displayProperties();