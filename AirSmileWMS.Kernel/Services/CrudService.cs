using AirSmileWMS.Kernel.Data;
using AirSmileWMS.Kernel.DTOs;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace AirSmileWMS.Kernel.Services
{
    /// <summary>
    /// Базовый сервис со всеми CRUD операциями.
    /// </summary>
    internal abstract class CrudService<TModel, TDto>
    where TModel : Models.Model
    where TDto : DTO
    {
        private const int PAGE_SIZE = 50;

        /// <summary>
        /// Добавить новую запись в бд.
        /// </summary>
        public async Task Create(TDto dto) 
        {
            using (var db = new Db())
            using (var transaction = db.Database.BeginTransaction())
            {
                try 
                {
                    var model = (TModel)Convert.ToModel(dto);
                    db.Set<TModel>().Add(model);
                    await db.SaveChangesAsync();
                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public async Task<List<TDto>> Read(int pageNumber = 1) 
        {
            using (var db = new Db())
            {
                var models = await db.Set<TModel>()
                    .OrderBy(m => m.CreatedAt)
                    .Skip((pageNumber - 1) * PAGE_SIZE)
                    .Take(PAGE_SIZE)
                    .ToListAsync();

                return models.Select(m => (TDto)Convert.ToDTO(m)).ToList();
            }
        }

        /// <summary>
        /// Обновить запись в бд.
        /// </summary>
        public async Task Update(TDto dto) 
        {
            using (var db = new Db())
            using (var transaction = db.Database.BeginTransaction())
            {
                try 
                {
                    var model = await db.Set<TModel>().FindAsync(dto.Id) ?? throw new InvalidOperationException("В базе данных нет того, что вы пытаетесь сейчас отредактировать.");
                    var updatedModel = (TModel)Convert.ToModel(dto);
                    db.Entry(model).CurrentValues.SetValues(updatedModel);
                    await db.SaveChangesAsync();
                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        /// <summary>
        /// Удалить запись из бд.
        /// </summary>
        public async Task Delete(TDto dto) 
        {
            using (var db = new Db())
            using (var transaction = db.Database.BeginTransaction())
            {
                try 
                {
                    var model = await db.Set<TModel>().FindAsync(dto.Id) ?? throw new InvalidOperationException("В базе данных нет того, что вы пытаетесь сейчас из нее удалить.");
                    await OnBeforeDelete(model, db);
                    db.Set<TModel>().Remove(model);
                    await db.SaveChangesAsync();
                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        /// <summary>
        /// Хук перед удалением (можно переопределить).
        /// Например, чтобы запретить удаление, если есть связанные сущности.
        /// </summary>
        protected virtual Task OnBeforeDelete(TModel model, Db db)
        {
            // По умолчанию ничего не делаем
            return Task.CompletedTask;
        }
    }
}
