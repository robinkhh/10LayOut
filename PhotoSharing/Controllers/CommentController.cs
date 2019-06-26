using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PhotoSharing.DAL;
using PhotoSharing.Models;


namespace PhotoSharing.Controllers
{
    public class CommentController : Controller
    {
        PhotoSharingContext context = new PhotoSharingContext();

        // GET: Comment
        [ChildActionOnly]
        public ActionResult _CommentsForPhoto(int PhotoID)
        {
            var comments = from c in context.Comments
                           where c.PhotoID == PhotoID
                           select c;
            ViewBag.PhotoID = PhotoID;

            return PartialView(comments.ToList());
        }
    }
}