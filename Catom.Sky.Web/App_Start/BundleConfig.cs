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
            bundles.Add(new StyleBundle("~/Content/bootstrap")
                .Include("~/Content/bootstrap/bootstrap.css")
                .Include("~/Content/bootstrap/bootstrap-responsive.css")
                .Include("~/Content/bootstrap/bootstrap-overrides.css")
                );

            bundles.Add(new Bundle("~/Content/font-awesome")
                .Include("~/Content/font-awesome/font-awesome.css")
                );

            bundles.Add(new Bundle("~/Content/global")
                .Include("~/Content/global/elements.css")
                .Include("~/Content/global/icons.css")
                .Include("~/Content/global/layout.css"));

            bundles.Add(new Bundle("~/Content/app")
                .Include("~/Content/compiled/*.css")
                .Include("~/Content/code-editor.css"));

            bundles.Add(new Bundle("~/Content/lib")
                .Include("~/Content/lib/*.css"));

            #endregion


            #region Script Bundles
            bundles.Add(new Bundle("~/Scripts/modernizr")
                .Include("~/Scripts/modernizr/modernizr-2.6.2-respond-1.1.0.js"));

            bundles.Add(new Bundle("~/Scripts/jquery")
                .Include("~/Scripts/jquery/jquery-latest.js"));

            bundles.Add(new Bundle("~/Scripts/jquery-ui")
                .Include("~/Scripts/jquery/jquery-ui-1.10.2.custom.min.js"));

            bundles.Add(new Bundle("~/Scripts/jquery.knob")
                .Include("~/Scripts/jquery/jquery.knob.js"));

            bundles.Add(new Bundle("~/Scripts/jquery.flot")
                .Include("~/Scripts/jquery/jquery.flot.js")
                .Include("~/Scripts/jquery/jquery.flot.resize.js")
                .Include("~/Scripts/jquery/jquery.flot.stack.js"));

            bundles.Add(new Bundle("~/Scripts/jquery.uniform")
                .Include("~/Scripts/jquery/jquery.uniform.min.js"));

            bundles.Add(new Bundle("~/Scripts/bootstrap")
                .Include("~/Scripts/bootstrap/bootstrap.min.js")
                .Include("~/Scripts/bootstrap/bootstrap.datepicker.js"));

            bundles.Add(new Bundle("~/Scripts/theme")
                .Include("~/Scripts/theme/theme.js"));


            #endregion
        }
    }
}