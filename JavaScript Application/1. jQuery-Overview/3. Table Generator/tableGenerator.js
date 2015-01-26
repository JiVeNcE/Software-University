/**
 * Created by Zhivko on 18.11.2014 г..
 */
(function($) {

    var wrapper,
        $table
        ;

   $wrapper = $('#wrapper');


   var json =  [{"manufacturer":"BMW","model":"E92 320i","year":2011,"price":50000,"class":"Family"},
    {"manufacturer":"Porsche","model":"Panamera","year":2012,"price":100000,"class":"Sport"},
    {"manufacturer":"Peugeot","model":"305","year":1978,"price":1000,"class":"Family"}];


     $table = $('<table/>').addClass('json-table')
         .append( '<tr> <td>' + 'Manufactured'  + '</td>' +
                       '<td>' + 'Model' + '</td>' +
                        '<td>' + 'Year'  + '</td>' +
                        '<td>' + 'Price'  + '</td>' +
                        '<td>' + 'Class'  + '</td></tr>');


         $.getJSON("JSON.php", function(data) {
        $.each(data, function (index, value) {
         $table.append( '<tr><td>' + value.manufacturer + '</td>  + ' +
                             '<td>' + value.model + '</td>' +
                             '<td>' + value.year + '</td>' +
                             '<td>' + value.price + '</td>' +
                             '<td>' + value.class + '</td></tr>');

        });
   });
    $wrapper.append($table);

}(jQuery));