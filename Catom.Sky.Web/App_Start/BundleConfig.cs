using System.Web;
using System.Web.Optimization;

namespace Catom.Sky.Web
{
    public class BundleConfig
    {
        // 有关 Bundling 的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkId=254725
        // 将相对路径下的 CSS、JS 文件绑定到虚拟路径上去，在页面上通过 Styles.Render、Script.Render 调用虚拟路径。
        public static void RegisterBundles(BundleCollection bundles)
        {
            // Use Bundle rather than StyleBundle or ScriptBundle in order to turn off minification (takes the already minified files).

            #region CSS Bundles
            bundles.Add(new StyleBundle("~/Content/css/bootstrap")
                .Include("~/Content/css/bootstrap/bootstrap.css")
                .Include("~/Content/css/bootstrap/bootstrap-responsive.css")
                .Include("~/Content/css/bootstrap/bootstrap-overrides.css"));

            bundles.Add(new Bundle("~/Content/css/font-awesome")
                .Include("~/Content/css/font-awesome/font-awesome.css"));

            bundles.Add(new Bundle("~/Content/css/global")
                .Include("~/Content/css/elements.css")
                .Include("~/Content/css/icons.css")
                .Include("~/Content/css/layout.css"));

            bundles.Add(new Bundle("~/Content/css/app")
                .Include("~/Content/css/compiled/*.css")
                .Include("~/Content/css/code-editor.css"));

            bundles.Add(new Bundle("~/Content/css/lib")
                .Include("~/Content/css/lib/*.css"));

            #endregion


            #region Script Bundles
            bundles.Add(new Bundle("~/Content/js/modernizr")
                .Include("~/Content/js/modernizr/modernizr-2.6.2-respond-1.1.0.js"));

            bundles.Add(new Bundle("~/Content/js/jquery")
                .Include("~/Content/js/jquery/jquery-latest.js"));

            bundles.Add(new Bundle("~/Content/js/jquery-ui")
                .Include("~/Content/js/jquery/jquery-ui-1.10.2.custom.min.js"));

            bundles.Add(new Bundle("~/Content/js/jquery.knob")
                .Include("~/Content/js/jquery/jquery.knob.js"));

            bundles.Add(new Bundle("~/Content/js/jquery.flot")
                .Include("~/Content/js/jquery/jquery.flot.js")
                .Include("~/Content/js/jquery/jquery.flot.resize.js")
                .Include("~/Content/js/jquery/jquery.flot.stack.js"));

            bundles.Add(new Bundle("~/Content/js/jquery.uniform")
                .Include("~/Content/js/jquery/jquery.uniform.min.js"));

            bundles.Add(new Bundle("~/Content/js/bootstrap")
                .Include("~/Content/js/bootstrap/bootstrap.min.js")
                .Include("~/Content/js/bootstrap/bootstrap.datepicker.js"));

            bundles.Add(new Bundle("~/Content/js/theme")
                .Include("~/Content/js/theme/theme.js"));

            bundles.Add(new Bundle("~/Content/js/app")
                .Include("~/Content/js/*.js"));

            #endregion
        }
    }
}