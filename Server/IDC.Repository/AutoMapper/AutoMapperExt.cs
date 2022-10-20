using AutoMapper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Repository.AutoMapper
{
    public static class AutoMapperExt
    {
        /// <summary>
        ///  类型映射
        /// </summary>
        public static T MapTo<T>(this object obj)
        {
            if (obj == null) return default;
            try
            {
                return AutoMapperHelper.Map<T>(obj);
            }
            catch (Exception ex)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap(obj.GetType(), typeof(T)));
                var mapper = config.CreateMapper();
                return mapper.Map<T>(obj);
            }
        }

        /// <summary>
        /// 集合列表类型映射
        /// </summary>
        public static List<TDestination> MapToList<TDestination>(this IEnumerable source)
        {
            try
            {
                return AutoMapperHelper.Map<List<TDestination>>(source);
            }
            catch (Exception ex)
            {
                Type sourceType = source.GetType().GetGenericArguments()[0];  //获取枚举的成员类型
                var config = new MapperConfiguration(cfg => cfg.CreateMap(sourceType, typeof(TDestination)));
                var mapper = config.CreateMapper();

                return mapper.Map<List<TDestination>>(source);
            }
        }

        /// <summary>
        /// 集合列表类型映射
        /// </summary>
        public static List<TDestination> MapToList<TSource, TDestination>(this IEnumerable<TSource> source)
        {
            try
            {
                return AutoMapperHelper.Map<List<TDestination>>(source);
            }
            catch (Exception ex)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap(typeof(TSource), typeof(TDestination)));
                var mapper = config.CreateMapper();

                return mapper.Map<List<TDestination>>(source);
            }
        }

        /// <summary>
        /// 类型映射
        /// </summary>
        public static TDestination MapTo<TSource, TDestination>(this TSource source, TDestination destination)
            where TSource : class
            where TDestination : class
        {
            if (source == null) return destination;
            try
            {
                return AutoMapperHelper.Map<TSource, TDestination>(source);
            }
            catch (Exception ex)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap(typeof(TSource), typeof(TDestination)));
                var mapper = config.CreateMapper();
                return mapper.Map<TDestination>(source);
            }
        }

    }
}
