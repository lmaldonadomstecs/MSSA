var url = "https://pokeapi.co/api/v2/pokemon/";
var whichPokemon;

function searchPokemon() {
    whichPokemon = document.getElementById("searchbar").value;
    whichPokemon = whichPokemon.toLowerCase();
    url = "https://pokeapi.co/api/v2/pokemon/"
    url += pokemon; // url = url + pokemon
    fetch(url)
    .then(response => response.json())
    .then(pokemon => {
        var parent = document.getElementById('parent');
        parent.innerHTML = '<p>' + pokemon.name +'</p>';
        parent.innerHTML += "<img src=" + pokemon.sprites.back_shiny + ">";
        // console.log(pokemon);
    }).catch(err => console.log(err))
}