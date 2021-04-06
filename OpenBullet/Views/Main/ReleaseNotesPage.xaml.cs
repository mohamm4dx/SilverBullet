using System.Windows.Controls;
using System.Windows.Documents;

namespace OpenBullet.Views.Main
{
    /// <summary>
    /// Interaction logic for ReleaseNotesPage.xaml
    /// </summary>
    public partial class ReleaseNotesPage : Page
    {
        public ReleaseNotesPage()
        {
            InitializeComponent();
            DataContext = this;
            AppendNote(new[] {
                "Uso agregado (corredor)",
                "Se agregaron nuevos algoritmos de hash (por its5Q)",
                "Codificación agregada (función)",
                "Se agregó la configuración de guardado automático en el apilador",
                "Se agregó un registro abierto en el bloc de notas",
                "Errores arreglados",
            });
            AppendNote(new[] {
            "Bloque websocket agregado (ws)",
            "Agregado enviar mensaje de texto a telegrama en el bloque de servicios públicos",
            "Se agregó el agente de usuario de set selenium en el bloque de acciones del navegador",
            "Ejecutor js fijo y actualizado",
            "Filtros de nitidez y trilla de color fijos (ocr)"});
            AppendNote(new[] {
               "Combos, proxy, configuración de arrastrar y soltar admitidos",
               "Ventana principal máxima fija",
               "Configuración loliX de carga fija",
               "Cuadro de entrada agregado para bots",
               "Se agregó la página de inicio de sesión Analizar (solicitud de bloqueo)",
               "Herramientas de Combos actualizadas",
            });
            AppendNote(new[] {
                "Errores corregidos",
                "Formato compatible loli, loliX, anom",
                "Se agregó un cuadro de diálogo de búsqueda y reemplazo en el editor de LoliScript",
                "OCR agregado",
                "Variable de conjunto agregada en (OCR)",
                "Procesamiento de imágenes agregado (con OpenCv y sin OpenCv)",
                "Se agregó (función) evaluación de cadena matemática",
                "Fecha agregada a solar en bloque de funciones",
                "Fecha agregada (solar) a gregoriana (función)",
                "Se agregó obtener el día restante (función)",
                "Se agregó obtener año, mes, día, hora (función) actual",
                "Añadida entrada a dígitos, letras, letrasOrdigits (función)",
                "Se agregó eliminar cadena en el bloque de funciones",
                "Número agregado a palabras (en) (función)",
                "Palabras agregadas a num (en) (función)",
                "Lista de subpalabras agregada",
                "Lista de palabras múltiples agregadas",
                "Añadida desactivación de la automatización en selenio (configuración)",
                "Se agregaron nuevos íconos y se actualizaron los íconos anteriores",
                "Se agregó generar android e ios (función) randomUA",
                "Añadido personalizado editable (comprobación de clave)",
                "Se agregó mostrar todos los tipos personalizados al pasar el mouse sobre la etiqueta personalizada",
                "Actualización agregada en la configuración seleccionada (corredor)",
                "Se agregó el descargador de tessdata (herramientas)",
                "Partidarios agregados (pestaña)",
                "Se admite la generación de números aleatorios de hasta 18 dígitos (función)",
                "Navegador actualizado (vista html) a CefSharp (navegador basado en cromo) (apilador)",
                "Actualizado depurador de inicio de sesión (apilador)",
                "Lista de selección actualizada (corredor)",
            });
        }

        private void AppendNote(string[] notes)
        {
            foreach (var note in notes)
            {
                var bold = new Bold(new Run("• "));
                bold.SetResourceReference(Bold.ForegroundProperty, "ForegroundMain");
                var paragraph = new Paragraph(bold);
                paragraph.SetResourceReference(Paragraph.ForegroundProperty, "ForegroundMain");
                paragraph.Inlines.Add(new Run(note));
                richTextBox.Document.Blocks.Add(paragraph);
            }
            var endPar = new Paragraph(new Bold(new Run("━━━━━━━━━━━━━━━━━━━━━━━━━")));
            endPar.SetResourceReference(Paragraph.ForegroundProperty, "ForegroundMain");
            richTextBox.Document.Blocks.Add(endPar);
        }

        public string App => $"🅾🅿🅴🅽🅱🆄🅻🅻🅴🆃 🅶🅴🆅🅴🆁  {SB.Version}";
    }
}
