using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Proyecto.Core.Entities;

namespace WebApp.Attributes
{
  /*  public class AutenticadoAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext Filtercontext)
        {
            base.OnActionExecuting(Filtercontext);

            if (!SessionHelper.ExistUserInSession())
            {
                Filtercontext.Result = new RedirectToRouteResult(new RouteValueDictionary(new
                {
                    Controller = "Account",
                    Action = "Index"
                }));    
            }
            else
            {
                IRepository Repositorio = new Model.Repository();
                int Iduser = SessionHelper.GetUser();
                var Usuario = Repositorio.FindEntity<Usuarios>(c => c.Id == IdUser);
                if (Usuario != null)
                {
                    SessionHelper.ActualizarSession(Usuario);
                }
            }               
        }
    }

    public class NoLoginAttribute : ActionFilterAttribute 
    {
        public override void OnActionExecuting(ActionExecutingContext Filtercontext)
        {
            base.OnActionExecuting(Filtercontext);

            if (SessionHelper.ExistUserInSession())
            {
                IRepository Repositorio = new Model.Repository();
                int IdUser = SessionHelper.GetUser();
                var Usuario = Repositorio.FindEntity<Usuario>(c => c.Id == IdUser && c.Activo == true);
                if (Usuario != null)
                {
                    SessionHelper.ActualizarSession(Usuario);

                    if (Usuario.Rol_Id == 1)
                    {
                        Filtercontext.Result = new RedirectToRouteResult(new RouteValueDictionary(new
                        {
                            Controller = "Admin",
                            Action = "Index",

                        }));
                    }
                }                          
            }
        }
    }
  */
}

