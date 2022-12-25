using System.Collections.Generic;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class CommentManager : GenericManager<Comment>, ICommentService
    {
        ICommentDal _commentDal;
        public CommentManager(ICommentDal commentDal) : base(new EfCommentRepository())
        {
            _commentDal = commentDal;
        }
        public List<Comment> TGetList(int id)
        {
            return _commentDal.GetListAll(x => x.BlogID == id);
        }
    }
}
