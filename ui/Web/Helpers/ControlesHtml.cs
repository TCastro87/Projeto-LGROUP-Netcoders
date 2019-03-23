using System.Web.Mvc;

namespace Web.Helpers
{
    public static class ControlesHtml
    {
        public static MvcHtmlString Button(this HtmlHelper helper, string type, string name, string id, string value, string css="btn btn-default")
        {
            var botao = new TagBuilder("input");

            botao.AddCssClass(css);
            botao.Attributes.Add("type", type);
            botao.Attributes.Add("name", name);
            botao.Attributes.Add("id", id);
            botao.Attributes.Add("value", value);

            /*
             Tipos de fechamento do TagRenderMode
             
             * Normal - <tag></tag>
             * StarTag - <tag>
             * EndTag - </tag>
             * SelfClosing - <tag />
             
             */


            //<input type = "button" class="btn btn-default" id="enviar" name="enviar" value="Enviar" />

            return MvcHtmlString.Create(botao.ToString(TagRenderMode.SelfClosing));
        }
    }
}