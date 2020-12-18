using System;
using Microsoft.AspNetCore.Components;
using EadCA3X00138115.Shared;
using System.Threading.Tasks;

namespace EadCA3X00138115.Pages
{
    public partial class Pokemon : ComponentBase
    {
        private Root pokemons;
        
        private string pokemonName = "mew";

        private string errorMessage;

        protected override async Task OnInitializedAsync()
        {
            await GetDataAsync();
        }

        private async Task GetDataAsync()
        {
            try
            {
                string uri = "https://pokeapi.co/api/v2/pokemon/" + pokemonName;
                pokemons = await Http.GetJsonAsync<Root>(uri);
                errorMessage = String.Empty;
            }
            catch (Exception e)
            {
                errorMessage = e.Message;
            }
        }
     
    }
}
