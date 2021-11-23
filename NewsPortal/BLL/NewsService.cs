using BLL.BEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DAL;

namespace BLL
{
    public class NewsService
    {
        public static List<NewsModel> Get()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<News, NewsModel>();
                c.CreateMap<Admin, AdminModel>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<List<NewsModel>>(NewsRepo.Get());
            return data;
        }

        public static List<string> GetCategory()
        {
            var data = NewsRepo.Get().Select(e => e.Category).ToList();
            return data;
        }

        public static void Add(NewsModel n)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<NewsModel, News>();
                
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<News>(n);
            NewsRepo.Add(data);
        }

        public NewsModel Get(int id)
        {
            return new NewsModel() { N_id = id, Category = "News" + id };
        }
    }
}
