using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Eu4ModEditor.JSON.Country
{
    //Define a country Json file
    [DataContract]
    class CountryJson
    {
        [DataMember]
        public CountryFile CountryFile;//ex: Alania.txt in common/countries of the mod folder

        [DataMember]
        public CountryTag CountryTag;/*ex: 00_countries.txt, this object give the tag 
        of the country*/

        [DataMember]
        public CountryLocalisation CountryLocalisation;/*ex: countries_l_english.yml, this attribute
        give the name in game of the country and his adjective*/
    }

    //Define a country file in mod folder ex : Alania.txt
    [DataContract]
    class CountryFile
    {
        [DataMember]
        public string CompletPath;//Chemin d'accès complet du fichier

        [DataMember]
        public string Path;//Chemin d'accès à partir du dossier common du mod folder

        [DataMember]
        public string Name;//Nom du pays
    }

    //Define a country_tag in mod folder ex : 00_countries.txt
    //contain a liste of tag link to the COuntryFile
    [DataContract]
    class CountryTag
    {
        [DataMember]
        public string Path;//Chemin d'accès du fichier

        [DataMember]
        public string Tag;//Tag du pays
    }

    //Define a localisation in mod folder ex : countries_l_english.yml
    //contain a liste of texte rely on some variable, here it's for name of country
    //and an adjective for the country
    [DataContract]
    class CountryLocalisation
    {
        [DataMember]
        public string Path;//Chemin d'accès du fichier

        [DataMember]
        public string Tag;//Tag du pays
    }

    //This class will manage creation and use of the CountryJson class
    class CountryTraitement
    {
        CountryJson countryJson;

        public CountryTraitement()
        {

        }
    }
}
