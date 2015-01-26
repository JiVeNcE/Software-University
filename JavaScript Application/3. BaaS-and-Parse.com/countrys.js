/**
 * Created by Zhivko on 25.11.2014 г..
 */

$(function() {
    $.ajaxSetup({
        headers: {
            "X-Parse-Application-Id": "jPK7s0gcfHLYwm5vkcSR8ARCqqR4aaGF6xfK6Mrj",
            "X-Parse-REST-API-Key": "qPGcaZUOu0s2AfXgUNab8A5HyX2azd18paIMqAwt"
        }
    });
    loadCountries();

    function loadCountries() {
        $.ajax({
            method: "GET",
            url: "https://api.parse.com/1/classes/Country",
            success: countryLoaded,
            error: error
        });
    }


    function countryLoaded(data) {
        $('body').empty();
        $('body').append('<h2>Countries</h2>')
            .append('<input type="text" id="add-country-text" />')
            .append('<a id="add-country-button" href="#">Add a country</a>')
            .append('<ul class="countries"></ul>');
        $('#add-country-button').click(addCounties);

        for (var c in data.results) {
            var country = data.results[c];
            var countryItem = $('<li></li>');
            var countryLink = $('<a href="#"></a>');
            countryLink.data('country', country);
            countryLink.text(country.name);
            countryLink.appendTo(countryItem);
            addControlButtons(countryItem, country);

            countryItem.appendTo($(".countries"));
        }

        $('.edit-country').click(editCountry);
    }

    function addControlButtons(countiesItem, country) {
        var removeButton = $('<a class="remove-country" href="#">Remove</a>');
        removeButton.data('countries', country);
        removeButton.click(deleteCountyClicked);

        var editButton = $('<a class="edit-country" href="#">Edit</a>');
        editButton.data('countries', country);
        editButton.click(editCountry);

        countiesItem.append('  ')
            .append(editButton)
            .append('  ')
            .append(removeButton);
    }

    function deleteCountyClicked() {
        var country = $(this).data('countries');
        $.ajax({
            method: "DELETE",
            url: 'https://api.parse.com/1/classes/Country/' + country.objectId,
            success: loadCountries,
            error: error
        });
    }

    function editCountry() {
        var country = $(this).data('countries');
        var oldCountryName = country.name;
        var newCountryName = prompt('Rename country:', oldCountryName) || oldCountryName;

        $.ajax({
            method: "PUT",
            data: JSON.stringify(
                {"name": newCountryName}
            ),
            contentType: "application/json",
            url: "https://api.parse.com/1/classes/Country/" + country.objectId,
            success: loadCountries,
            error: error
        });
    }



  function addCounties() {

      var countryName = $('#add-country-text').val();

      $.ajax({
          method: "POST",
          url: 'https://api.parse.com/1/classes/Country',
          contentType: "application/json",
          data: JSON.stringify({
              "name": countryName
          }),
          success: loadCountries,
          error: error
      });
  };

    loadTowns();
    function loadTowns(){
        var country = $(this).data('country');

        if (!$(this).parent().has('ul').length) {
            var targetLi = $("li:contains('" + country.name + "')");
            var townName = $('<input type="text" class="add-town-text" />');
            var addTownButton = $('<a id="add-town-button" href="#">Add a town</a>');
            addTownButton.data('country', country);
            addTownButton.data('townName', townName);
            addTownButton.click(addTown);
            targetLi.append(townName).append(addTownButton);
        }

        $.ajax({
            method: "GET",
            url: 'https://api.parse.com/1/classes/Town',
            success: townsLoaded,
            error: error
        });
    }

    function townsLoaded(data){
        var country = data.results[0].country;
        var targetLi = $("li:contains('" + country.objectId + "')");

        if(targetLi.has('ul').length) {
            $('"' + targetLi + " ul").empty();
        }

        var townsUl = $('<ul>');
        for (var t in data.results){
            var editTownButton = $('<a href="#">Edit</a>');
            editTownButton.data('town', data.results[t]);
            console.log(data.results[t]);
            editTownButton.click(editTown);

            var removeTownButton = $('<a href="#">Remove</a>');
            removeTownButton.data('town', data.results[t]);
            removeTownButton.click(removeTown);

            townsUl.append($('<li>' + data.results[t].name + '</li>'))
                .append(editTownButton)
                .append(' ')
                .append(removeTownButton);
        }

        townsUl.appendTo(targetLi);

    }

    function addTown(){
        var townName = $(this).data('townName').val();
        var country = $(this).data('country');

        $.ajax({
            method: "POST",
            data: JSON.stringify(
                {
                    "name": townName,
                    "country":
                    {
                        "__type": "Pointer",
                        "className": "Country",
                        "objectId": country.name
                    }
                }
            ),
            contentType: "application/json",
            url: "https://api.parse.com/1/classes/Town",
            success: loadTowns,
            error: error
        });
    }

    function editTown(){
        var town = $(this).data('town');
        var oldTownName = town.name;
        var newTownName = prompt('Rename country:', oldTownName) || oldTownName;

        $.ajax({
            method: "PUT",
            data: JSON.stringify(
                {
                    "name": newTownName
                }
            ),
            contentType: "application/json",
            url: "https://api.parse.com/1/classes/Town/" + town.objectId,
            success: loadTowns,
            error: error
        });
    }

    function removeTown(){
        var town = $(this).data('town');
        console.log(town);
        $.ajax({
            method: "DELETE",
            url: "https://api.parse.com/1/classes/Town/" + town.objectId,
            success: loadTowns,
            error: error
        });
    }



    function error() {
        alert('Cannot load AJAX data.')
    }

}());