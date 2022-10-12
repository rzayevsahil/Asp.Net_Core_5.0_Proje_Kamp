using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        private EfCommentRepository efCommentRepository;

        public CommentManager()
        {
            efCommentRepository = new EfCommentRepository();
        }
        public void TInsert(Comment item)
        {
            efCommentRepository.Insert(item);
        }

        public void TDelete(Comment item)
        {
            efCommentRepository.Delete(item);
        }

        public void TUpdate(Comment item)
        {
            efCommentRepository.Update(item);
        }

        public List<Comment> TGetList()
        {
            return efCommentRepository.GetListAll();
        }

        public Comment TGetByID(int id)
        {
            return efCommentRepository.GetByID(id);
        }
    }
}
