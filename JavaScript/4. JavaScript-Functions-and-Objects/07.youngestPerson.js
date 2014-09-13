/**
 * Created by Zhivko on 27.7.2014 г..
 */

function findYoungestPerson(persons)  {
        var minAge =  Number.MAX_VALUE;

        for( var key = 0 ; key < persons.length ; key++){
            var age = persons[key].age;
            if(age < minAge){
                minAge = age;
            }

        }
        for (var key = 0 ; key < persons.length ; key++){
            if(minAge == persons[key].age){
                return "The youngest person is " + persons[key].firstname + " " + persons[key].lastname;
            }
        }
    return minAge;


}

    console.log(findYoungestPerson([
            { firstname : 'George', lastname: 'Kolev', age: 32},
            { firstname : 'Bay', lastname: 'Ivan', age: 81},
            { firstname : 'Baba', lastname: 'Ginka', age: 40}]
    ));