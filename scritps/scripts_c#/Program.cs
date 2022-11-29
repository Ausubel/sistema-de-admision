using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Pruebas
{
    internal class Program
    {
        private static Random randoms = new Random();
        static void Main(string[] args)
        {
            string[] nombre = { "Adel", "Adonis", "Ajaz", "Akos", "Aldo", "Amets", "Amaro", "Aquiles", "Algimantas", "Alpidio", "Amrane", "Anish", "Arián", "Ayun", "Azariel", "Bagrat", "Bencomo", "Bertino", "Candi", "Cesc", "Cirino", "Crisólogo", "Cruz", "Danilo", "Dareck", "Dariel", "Darin", "Delmiro", "Damen", "Dilan", "Dipa", "Doménico", "Drago", "Edivaldo", "Elvis", "Elyan", "Emeric", "Engracio", "Ensa", "Eñaut", "Eleazar", "Eros", "Eufemio", "Feiyang", "Fiorenzo", "Foudil", "Galo", "Gastón", "Giulio", "Gautam", "Gentil", "Gianni", "Gianluca", "Giorgio", "Gourav", "Grober", "Guido", "Guifre", "Guim", "Hermes", "Inge", "Irai", "Iraitz", "Iyad", "Iyán", "Jeremías", "Joao", "Jun", "Khaled", "Leónidas", "Lier", "Lionel", "Lisandro", "Lucián", "Mael", "Misael", "Moad", "Munir", "Nael", "Najim", "Neo", "Neil", "Nikita", "Nilo", "Otto", "Pep", "Policarpo", "Radu", "Ramsés", "Rómulo", "Roy", "Severo", "Sidi", "Simeón", "Taha", "Tao", "Vadim", "Vincenzo", "Zaid", "Zigor", "Zouhair", "Hugo", "Mateo", "Martín", "Lucas", "Leo", "Daniel", "Alejandro", "Manuel", "Pablo", "Álvaro", "Adrián", "Enzo", "Mario", "Diego", "David", "Oliver", "Marcos", "Thiago", "Marco", "Álex", "Javier", "Izan", "Bruno", "Miguel", "Antonio", "Gonzalo", "Liam", "Gael", "Marc", "Carlos", "Juan", "Ángel", "Dylan", "Nicolás", "José", "Sergio", "Gabriel", "Luca", "Jorge", "Darío", "Íker", "Samuel", "Eric", "Adam", "Héctor", "Francisco", "Rodrigo", "Jesús", "Erik", "Amir", "Jaime", "Ian", "Rubén", "Aarón", "Iván", "Pau", "Víctor", "Guillermo", "Luis", "Mohamed", "Pedro", "Julen", "Unai", "Rafael", "Santiago", "Saúl", "Alberto", "Noah", "Aitor", "Joel", "Nil", "Jan", "Pol", "Raúl", "Matías", "Martí", "Fernando", "Andrés", "Rayan", "Alonso", "Ismael", "Asier", "Biel", "Ander", "Aleix", "Axel", "Alan", "Ignacio", "Fabio", "Neizan", "Jon", "Teo", "Isaac", "Arnau", "Luka", "Max", "Imran", "Youssef", "Anas", "Elías" };
            string[] ap_pat = { "González", "Muñoz", "Rojas", "Díaz", "Pérez", "Soto", "Contreras", "Silva", "Martínez", "Sepúlveda", "Morales", "Rodríguez", "López", "Fuentes", "Hernández", "Torres", "Araya", "Flores", "Espinoza", "Valenzuela", "Castillo", "Tapia", "Reyes", "Gutiérrez", "Castro", "Pizarro", "Álvarez", "Vásquez", "Sánchez", "Fernández", "Ramírez", "Carrasco", "Gómez", "Cortés", "Herrera", "Núñez", "Jara", "Vergara", "Rivera", "Figueroa", "Riquelme", "García", "Miranda", "Bravo", "Vera", "Molina", "Vega", "Campos", "Sandoval", "Orellana", "Cárdenas", "Olivares", "Alarcón", "Gallardo", "Ortiz", "Garrido", "Salazar", "Guzmán", "Henríquez", "Saavedra", "Navarro", "Aguilera", "Parra", "Romero", "Aravena", "Vargas", "Vázquez", "Cáceres", "Yáñez", "Leiva", "Escobar", "Ruiz", "Valdés", "Vidal", "Salinas", "Zúñiga", "Peña", "Godoy", "Lagos", "Maldonado", "Bustos", "Medina", "Pino", "Palma", "Moreno", "Sanhueza", "Carvajal", "Navarrete", "Sáez", "Alvarado", "Donoso", "Poblete", "Bustamante", "Toro", "Ortega", "Venegas", "Guerrero", "Mendoza", "Farías", "San Martín", "Melgar", "Melgarejo", "Melgoza", "Mellado", "Membrila", "Mena", "Menchaca", "Mendes", "Mendez", "Mendia", "Mendieta", "Mendiola", "Mendosa", "Meneces", "Meneses", "Meras", "Mercado", "Merced", "Mereles", "Merino", "Merlin", "Merlo", "Merodio", "Mesquite", "Messa", "Mexia", "Meza", "Michaca", "Miguel", "Milan", "Minchaca", "Minero", "Minguela", "Minxares", "Mira", "Miramontes", "Miranda", "Mireles", "Mitzi", "Moctesuma", "Modesto", "Mogica", "Moia", "Mojica", "Molina", "Molla", "Molleda", "Monares", "Moncada", "Moncayo", "Mondragon", "Monjaras", "Monreal", "Montana", "Montanes", "Montano", "Monte", "Montecillo", "Montecinos", "Enriquez", "Enrrique", "Enrriquez", "Ensiso", "Eredia", "Erera", "Ernandes", "Errera", "Escalante", "Escalera", "Escamilla", "Escandon", "Escobar", "Escobedo", "Escojido", "Escovar", "Escutia", "Espalin", "Espana", "Esparcia", "Esparza", "Espejo", "Espindola", "Espinel", "Espinola", "Espinoza", "Espiritu", "Espitia", "Esqueda", "Esquibel", "Esquibias", "Esquivel", "Esquivias", "Esteban", "Estebes", "Estevan", "Esteves", "Estrada", "Estrella", "Estreya", "Estudillo", "Europa", "Evangelista", "Evans", "Evora", "Fabela", "Fabian", "Facio", "Fajardo", "Falcon", "Farfan", "Farias", "Faustino", "Faxardo", "Feliciano", "Felis", "Feliz", "Ferel", "Fermin", "Gandara", "Gaona", "Garambuyo", "Garate", "Garavito", "Garay", "Garcia", "Gardea", "Garduno", "Garfias", "Garia", "Garibai", "Garibaldo", "Garibay", "Garivay", "Garnica", "Garrido", "Garsa", "Garsia", "Garza", "Garzia", "Gasca", "Gascon", "Gaspar", "Gastan", "Gatica", "Gauna", "Gausin", "Gavia", "Gavilan", "Gavilanes", "Gavino", "Gayardo", "Gayo", "Gaytan", "Gazca", "Gebara", "George", "Gerardo", "Gerero", "German", "Gerra", "Gertrudis", "Gervacio", "Ghco", "Ghcuaa", "Ghcuiy", "Ghcusi", "Ghghu", "Ghichi", "Ghico", "Ghicuau", "Ghicuey", "Ghicuiy", "Ghicusi", "Ghighi", "Ghighu", "Ghihuaco", "Ghihuidzu", "Grusiaga", "Guadalaxara", "Guadalupe", "Guadarrama", "Guadiana", "Guajardo", "Guanajuato", "Guaracha", "Guardado", "Guardia", "Guardiola", "Guarneros", "Gudino", "Guereca", "Guerra", "Guerrero", "Guerta", "Guete", "Guevara", "Guia", "Guido", "Guijarro", "Guillen", "Guilo", "Guimenes", "Guines", "Guipe", "Guisa", "Guisar", "Guiterres", "Guiza", "Gurrola", "Gusman", "Gutieres", "Gutierrez", "Haro", "Harris", "Haumada", "Helguera", "Henrique", "Henriquez", "Heredia", "Hererra", "Hermoso", "Hernandes", "Hernandez", "Herrada", "Herrera", "Herver", "Hibarra", "Hierro", "Higareda", "Higuera", "Hijar", "Hilario", "Hinojosa", "Hornelas", "Horosco", "Horta", "Abad", "Abalos", "Abarca", "Abendano", "Abila", "Abina", "Abitua", "Aboites", "Abonce", "Abrego", "Abrica", "Abrigo", "Abundis", "Aburto", "Acebedo", "Acebes", "Acencio", "Acero", "Acevedo", "Aceves", "Acha", "Adan", "Adrian", "Agirre", "Agredano", "Aguado", "Aguallo", "Aguas", "Aguayo", "Agueda", "Aguero", "Aguila", "Aguilar", "Aguilera", "Aguinaga", "Aguino", "Aguirre", "Agundis", "Ahuatl", "Ahumada", "Aiala", "Aillon", "Alamilla", "Alamiya", "Alamo", "Alanis", "Alarcon", "Alatorre", "Alatriste", "Alaves", "Alba", "Albarado", "Albares", "Albarran", "Alberto", "Albino", "Albis", "Albornos", "Alcantar", "Alcaras", "Alcocer", "Alcorta", "Aldaco", "Aldape", "Aldaz", "Alderete", "Alejandro", "Alejo", "Aleman", "Alexos", "Alfaro", "Alferes", "Alfonso", "Alguera", "Allala", "Allende", "Almager", "Almaguer", "Almanza", "Almaras", "Almasan", "Almeda", "Almejo", "Almendares", "Almodovar", "Almonte", "Almorin", "Alonzo", "Altamirano", "Altra", "Altusar", "Alva", "Alvarado", "Alvares", "Alverto", "Alvidres", "Alvillar", "Alvino", "Alviso", "Amador", "Amalla", "Amaral", "Amarilla", "Amaro", "Amaya", "Ambris", "Ambrocio", "Americano", "Amescua", "Amesola", "Amesquita", "Ana", "Analla", "Anaya", "Anda", "Anderson", "Andrada", "Andrade", "Suro", "Sustaita", "Tabarez", "Tabera", "Taboada", "Tafolla", "Tagle", "Talabera", "Talamantes", "Talavera", "Talledos", "Tamaio", "Tamallo", "Tamaris", "Tamayo", "Tapias", "Tarin", "Tavares", "Tecol", "Tecpanecatl", "Tegeda", "Tehuitzil", "Tejeda", "Teles", "Tello", "Temascal", "Temblador", "Tena", "Teodoro", "Tepale", "Tepos", "Teran", "Terraso", "Terriquez", "Terrones", "Teutli", "Texeda", "Teyes", "Teyo", "Thelles", "Thobar", "Thorres", "Thovar", "Tierra", "Tierrablanca", "Tijon", "Timal", "Tinajero", "Tinoco", "Tirado", "Tiscareno", "Tisnado", "Tlapaltotoli", "Tobares", "Toledo", "Tolentino", "Tome", "Topete", "Tore", "Venavides", "Venegas", "Venites", "Ventura", "Vera", "Verdugo", "Verdusco", "Vergara", "Vermejo", "Vernal", "Veserra", "Vetancur", "Vetancurt", "Vetansos", "Vexarano", "Vibanco", "Vibar", "Vicencio", "Vicente", "Vicinais", "Vidaurri", "Vidro", "Viera", "Viernes", "Vieyra", "Vigil", "Vigueria", "Vilchis", "Villa", "Villafane", "Villafranco", "Villafuerte", "Villagra", "Villalbaso", "Villalobos", "Villalon", "Villalovos", "Villalpando", "Villalva", "Villalvazo", "Villamar", "Villami", "Villanueba", "Villapando", "Villareal", "Villasana", "Villasenor", "Villasor", "Villatoro", "Villaverde", "Villavicencio", "Villegas", "Villela", "Villicana", "Vincent", "Vique", "Viramontes", "Virjan", "Viscaino", "Zapote", "Zarabia", "Zarate", "Zaravia", "Zavala", "Zeballos", "Zedano", "Zedillo", "Zeferino", "Zenon", "Zepeda", "Zerbantes", "Zerrano", "Zertucha", "Zervantes", "Zetina", "Zisneros", "Zolis", "Zolorsano", "Zoriano", "Zosa", "Zosaya", "Zotelo", "Zoto", "Zuares", "Zubia", "Zuniga", "Zurita", "Melgar", "Melgarejo", "Melgoza", "Mellado", "Membrila", "Mena", "Menchaca", "Mendes", "Mendez", "Mendia", "Mendieta", "Mendiola", "Mendosa", "Meneces", "Meneses", "Meras", "Mercado", "Merced", "Mereles", "Merino", "Merlin", "Merlo", "Merodio", "Mesquite", "Messa", "Mexia", "Meza", "Michaca", "Miguel", "Milan", "Minchaca", "Minero", "Minguela", "Minxares", "Mira", "Miramontes", "Miranda", "Mireles", "Mitzi", "Moctesuma", "Modesto", "Mogica", "Moia", "Mojica", "Molina", "Molla", "Molleda", "Monares", "Moncada", "Moncayo", "Mondragon", "Monjaras", "Monreal", "Montana", "Montanes", "Montano", "Monte", "Montecillo", "Montecinos", "Salbatierra", "Salcedo", "Saldana", "Saldibar", "Sales", "Salgado", "Salinas", "Sallabedra", "Salmeron", "Salsedo", "Salsido", "Salvador", "Salvatierra", "Samaniego", "Samano", "Samarron", "Samora", "Samorano", "Samores", "Samudio", "Sanabia", "Sanabria", "Sanavia", "Sanbrano", "Sanchez", "Sandobal", "Sanguino", "Sanmiguel", "Santa", "Santana", "Santander", "Santarrosa", "Santellan", "Santiago", "Santiestevan", "Santillan", "Santis", "Santiyan", "Santo", "Santollo", "Santos", "Santoya", "Santoz", "Sapata", "Sapien", "Sapote", "Saquau", "Saquihui", "Sarabia", "Saracho", "Saragosa", "Sarate", "Saravia", "Sarco", "Sardo", "Saria", "Sarmiento", "Sasa", "Sasayu" };
            int[] edad = { 17, 18, 19, 20, 21, 22, 23, 24, 25 };
            /*
            for (int x = 20220007; x <= 20221006; x++)
            {
                Console.WriteLine($"({x},{randoms.Next(1, 40)},'{nombre[randoms.Next(nombre.Length)]}','{ap_pat[randoms.Next(ap_pat.Length)]}','{ap_pat[randoms.Next(ap_pat.Length)]}',{edad[randoms.Next(edad.Length)]},{Math.Round(randoms.NextDouble() * 2000, 3)}),");
            }
            /*
            for (int x = 20220006; x <= 20221006; x++)
            {
                Console.WriteLine(($"UPDATE postulante set nota = {Math.Round(randoms.NextDouble() * 2000, 3)} where id_postulante = {x};").Replace(',', '.'));
            }/*
            for (int x = 20220000; x <= 20221006; x++)
            {
                Console.WriteLine($"UPDATE postulante set nota = NULL where codigo_postulante = {x};\r\n");
            }*/
            Console.WriteLine();
            //  <-- Keep this information secure! -->
            Console.WriteLine("MachineName: {0}", Environment.MachineName);
            Console.ReadKey();
        }
        public static string MachineName { get; }
        private static Random random = new Random();
        
        public static string Aleatorio(int max)
        {
            string output = "";
            for (int i = 0; i < max; i++)
            {               
                int val_iter = random.Next(5);
                switch (val_iter)
                {
                    case 0:
                        output += "A";
                        break;
                    case 1:
                        output += "B";
                        break;
                    case 2:
                        output += "C";
                        break;
                    default:
                        output += "D";
                        break;
                }
            }
            return output;
        }
    }
}
