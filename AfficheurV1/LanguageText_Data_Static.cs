using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AfficheurV1
{

    public static class LanguageText_Data_Static
    {
        //public string CurrentLanguage { set; get; }


        public static string CurrentLanguage_Static { set; get; }
        public static string DefaultLanguage_Static()
        {
            return "FR";
        }


        public static readonly string[] Left_Effect_Static_FR = { "Aucune transition","Bas vers le haut","Haut vers le bas",
            "Defilement vers la gauche","Defilement vers la droite","Defilement vers le haut","Defilement vers le bas","Effet neige"};
        public static readonly string[] Enter_Effect_Static_FR = { "Aucune transition","Bas vers le haut","Haut vers le bas",
            "Defilement vers la gauche","Defilement vers la droite","Defilement vers le haut","Defilement vers le bas","Effet neige"};
          public static readonly string[] Speed_FR = { "Vitesse 1 (Lent)", "Vitesse 2", "Vitesse 3", "Vitesse 4 (Rapide)" };
        public static readonly string[] Label_FR = { "Numéro d'afficheur", "Page de Message", "Message a Afficher",
        "Transition apparition message","Transition Disparition message","Vitesse de defilement","Coleur du text","Texte à afficher","N° de ligne"};
        public static readonly string[] GroupeBox_FR = { "Paramètre de Page", "Parametres Genéraux et Dessin",
        "Dialogue sur la ligne Serial","Message","Parametre de l'affichage","Jusqu'a la Page"};

        public static readonly string[] Button_FR = { "Paramètres RS232", "Luminosité +", "Luminosité -","Changer de Langue",
            "Export Historique com. XML ","Dessin","Valider","Info LRC","Envoyer","Paramètres Ethernet" };
        public static readonly string[] Text_color_FR = {"Rouge", "Vert","Orange","Rouge inversé","Vert inversé",
            "Orange inversé","Rouge font Vert","Vert font Rouge","Rouge Vert Orange","Arc en ciel"};
        public static readonly string[] Error_Message_FR = { "Probleme avec la communication Serial !", " Pas de port disponible !", "Port non selectionné !", "Une erreur inconnue !"};
        public static readonly string[] Messages_ToolTip_FR = {"Pas de port disponible","Un nombre SVP"};






        public static readonly string[] Left_Effect_Static_EN = {"No transition","bottom up", "top down", "scroll left",
            "Scroll right", "Scroll up", "Scroll down", "Snow effect"};
        public static readonly string[] Enter_Effect_Static_EN = {"No transition","bottom up", "top down", "scroll left",
            "Scroll right", "Scroll up", "Scroll down", "Snow effect"};

        public static readonly string[] Speed_EN = { "Speed 1 (Slow)", "Speed 2", "Speed 3", "Speed 4 (Fast)" };

        public static readonly string[] Label_EN = {"Display Number :","Page of message","Message to display",
            "Transition appearance message", "Transition Disappearance message", "Scroll Speed", "Text color", "Text to display","Line number"};
        public static readonly string[] GroupeBox_EN = { "Settings of Page", "General Settings and Drawing",
            "Serial Output","Message","Display settings","To page"};

        public static readonly string[] Button_EN = {"RS232 Settings", "Brightness +", "Brightness -","Change Language",
            "Export message in XML", "Drawing", "Validate", "Info LRC", "Send","Ethernet Settings"};
        public static readonly string[] Text_color_EN = {"Red", "Green", "Orange", "Inverted Red", "Inverted Green",
 "Inverted Orange", "Red Make Green", "Green Make Red", "Red Green Orange", "Rainbow"};





        public static readonly string[] Left_Effect_Static_SP = {"Sin transición", "Up up", "Up down",
            "Desplácese hacia la izquierda", "Desplácese hacia la derecha", "Desplácese hacia arriba", "Desplazarse hacia abajo", "Efecto Nieve"};
        public readonly static string[] Enter_Effect_Static_SP = {"Sin transición", "Up up", "Up down",
"Desplácese hacia la izquierda", "Desplácese hacia la derecha", "Desplácese hacia arriba", "Desplazarse hacia abajo", "Efecto Nieve"};
        public static readonly string[] Speed_SP = {"Velocidad 1 (lenta)", "Velocidad 2", "Velocidad 3", "Velocidad 4 (rápida)"};
        public static readonly string[] Label_SP = {"Caller ID", "Message Page", "Message to Display",
        "Transición de la apariencia del mensaje", "Transición de desaparición del mensaje", "Velocidad de desplazamiento", "Color del texto","Texto para mostrar","????????"};
        public static readonly string[] GroupeBox_SP = {"Parámetro de página", "Parámetros generales y dibujo",
"Diálogo en línea serie", "Mensaje", "Configuración de pantalla", "Hasta página"};

        public static readonly string[] Button_SP = {"Configuración RS232", "Brillo +", "Brillo -", "Cambiar idioma",
            "Exportación de historial XML", "Dibujo", "Validar", "Información LRC", "Enviar", "Configuración Ethernet"};
        public static readonly string[] Text_color_SP = {"Red", "Green", "Orange", "Inverted Red", "Inverted Green",
            "Inverted Orange", "Red Make Green", "Green Make Red", "Red Green Orange", "Rainbow"};
        public static readonly string[] Error_Message_EN = {"¡Problema con la comunicación en serie!", "¡No hay puerto disponible!", "¡Puerto no seleccionado!" };
        public static readonly string[] Messages_ToolTip_EN = {"No hay puerto disponible", "Un número por favor"};




    }
}
