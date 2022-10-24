using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using AppGuiaCurso.Models;

namespace AppGuiaCurso.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PrimeiroAno : ContentPage
    {
        public PrimeiroAno()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Programação Web I",

                    AtribuicoesResponsabilidades = "Desenvolver sites para Web.",

                    ValoresAtitudes = "Incentivar a criatividade.\r\nEstimular a organização.\r\nEstimular o interesse na resolução de situações-problema.",

                    Habilidades = "Implementar páginas para a Internet.",

                    Competencias = "·Desenvolver páginas para internet, utilizando linguagem de marcação de texto.\r\n ·Utilizar linguagem de script para Web.\r\n1. ·Construir folhas de estilo",
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Fundamentos da Informática",

                    AtribuicoesResponsabilidades = "Operar sistemas computacionais.",

                    ValoresAtitudes = "·Desenvolver a criticidade.\r\n ·Incentivar comportamentos éticos.\r\n ·Promover ações que considerem o respeito às normas estabelecidas.\r\n",

                    Habilidades = "·Distinguir arquiteturas de sistemas de hardware\r\ne software. \r\n ·Executar comandos em interface de linha de \r\ncomando.\r\n ·Utilizar sistemas computacionais",

                    Competencias = "·Articular conhecimentos de sistemas \r\ncomputacionais.\r\n2. ·Distinguir sistemas computacionais.",
                };
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            try 
            {
                var c = new Componente
                {
                    Nome = "Análise e Projetos de Sistemas",

                    AtribuicoesResponsabilidades = "Elaborar projetos de sistema de informação.",

                    ValoresAtitudes = "·Incentivar a criatividade. \r\n·Estimular a organização. \r\n·Estimular o interesse na resolução de situações-problema. ",

                    Habilidades= "·Coletar requisitos de usuários e sistemas. \r\n ·Utilizar métodos de abordagem, coleta de dados e procedimentos de pesquisa. +" +
                    "\r\n·Aplicar modelo Cascata no desenvolvimento de \r\nsistemas. \r\n·Aplicar modelos Ágeis a projetos de software.", 

                    Competencias= "·Modelar projeto de sistemas. \r\n·Selecionar modelos para o desenvolvimento de sistemas. ",

                };
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }
        
        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            try 
            {
                var c = new Componente
                {
                    Nome = "Design Digital",

                    AtribuicoesResponsabilidades = "·Desenvolver elementos gráficos para aplicativos e sites.",

                    ValoresAtitudes = "·Incentivar a criatividade.\r\nRespeitar as manifestações culturais de outros povos.\r\nEstimular o interesse na resolução de situações-problema",

                     Habilidades = "·Manipular ou construir elementos visuais para \r\naplicativos, sites.\r\n",

                     Competencias = "·Desenvolver interfaces visuais para aplicativos e \r\nsites.",
                };
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_4(object sender, EventArgs e)
        {
            try 
            {
                var c = new Componente
                {
                    Nome="Técnicas de Programação e Algoritmos",

                    AtribuicoesResponsabilidades= "Realizar versionamento no desenvolvimento de programas.\r\nUtilizar algoritmos em linguagem de programação, +" +
                    "por meio de ambientes de desenvolvimento de acordo \r\ncom as necessidades.\r\n",

                    ValoresAtitudes= "Incentivar atitudes de autonomia.\r\nIncentivar comportamentos éticos.\r\nEstimular o interesse na resolução de situações-problema.",

                    Habilidades="",

                    Competencias= "·Elaborar algoritmos.\r\n ·Codificar programas, utilizando técnica de programação estruturada. +" +
                    "\r\n ·Depurar e versionar programas, utilizando ambiente de desenvolvimento integrado.",
                    
                };
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_5(object sender, EventArgs e)
        {
            try 
            {
                var c = new Componente
                {
                    Nome="Banco de Dados I",

                    AtribuicoesResponsabilidades = "Modelar banco de dados.",

                     ValoresAtitudes = "·Estimular a organização. \r\n·Estimular o interesse na resolução de situações-problema. \r\n ·Promover ações que considerem o respeito às normas estabelecidas. ",

                     Habilidades = "·Levantar as necessidades de informações do sistema.\r\n ·Normalizar tabelas de banco de dados.\r\n ·Associar as tabelas para construção de banco de +" +
                     "\r\ndados.\r\n ·Aplicar linguagem SQL na construção de tabelas.\r\n",

                      Competencias = "·Desenvolver modelo de banco de dados",

                };
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }
    }

}