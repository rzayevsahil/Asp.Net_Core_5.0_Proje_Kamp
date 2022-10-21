using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }
        public void TInsert(Comment item)
        {
            _commentDal.Insert(item);
        }

        public void TDelete(Comment item)
        {
            _commentDal.Delete(item);
        }

        public void TUpdate(Comment item)
        {
            _commentDal.Update(item);
        }

        public List<Comment> TGetList()
        {
            throw new NotImplementedException();
        }

        public List<Comment> TGetList(int id) 
        {
            return _commentDal.GetListAll(x => x.BlogID == id);
        }

        public Comment TGetByID(int id)
        {
            return _commentDal.GetByID(id);
        }
    }
}
