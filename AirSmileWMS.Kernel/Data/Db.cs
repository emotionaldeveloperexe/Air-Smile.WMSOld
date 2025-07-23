using AirSmileWMS.Kernel.Models;
using AirSmileWMS.Kernel.VOs;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace AirSmileWMS.Kernel.Data
{
    /// <summary>
    /// База данных.
    /// </summary>
    public class Db : DbContext
    {
        public Db() : base("AirSmileWMSConnection") { }

        #region Таблицы БД

        /// <summary>
        /// Категории товара.
        /// </summary>
        public DbSet<Category> Categories { get; set; }

        /// <summary>
        /// Направления.
        /// </summary>
        public DbSet<Direction> Directions { get; set; }

        /// <summary>
        /// Товары для наборов.
        /// </summary>
        public DbSet<Good> Goods { get; set; }

        /// <summary>
        /// Приходы.
        /// </summary>
        public DbSet<GoodArrival> GoodArrivals { get; set; }

        /// <summary>
        /// Возвраты.
        /// </summary>
        public DbSet<GoodRefund> GoodRefunds { get; set; }

        /// <summary>
        /// Источники товаров.
        /// </summary>
        public DbSet<GoodSource> GoodSources { get; set; }

        /// <summary>
        /// Поставщики товаров.
        /// </summary>
        public DbSet<GoodSupplier> GoodSuppliers { get; set; }

        /// <summary>
        /// Список покупок.
        /// </summary>
        public DbSet<GoodToBuy> GoodsToBuy { get; set; }

        /// <summary>
        /// Отслеживание товаров.
        /// </summary>
        public DbSet<GoodTracking> GoodsTracking { get; set; }

        /// <summary>
        /// Наборы.
        /// </summary>
        public DbSet<Pack> Packs { get; set; }

        /// <summary>
        /// Товары, идущие в наборы.
        /// </summary>
        public DbSet<PackGood> PackGoods { get; set; }

        /// <summary>
        /// Поставки.
        /// </summary>
        public DbSet<Supply> Supplies { get; set; }

        /// <summary>
        /// Задания.
        /// </summary>
        public DbSet<Task> Tasks { get; set; }

        /// <summary>
        /// Задания на сборку.
        /// </summary>
        public DbSet<TaskToCollect> TasksToCollect { get; set; }

        /// <summary>
        /// Задания на упаковку.
        /// </summary>
        public DbSet<TaskToPack> TasksToPack { get; set; }

        /// <summary>
        /// Задания на поставку.
        /// </summary>
        public DbSet<TaskToSupply> TasksToSupply { get; set; }

        /// <summary>
        /// пользователи.
        /// </summary>
        public DbSet<User> Users { get; set; }

        /// <summary>
        /// Действия пользователей.
        /// </summary>
        public DbSet<UserAction> UserActions { get; set; }

        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Убираем автоматическое добавление "s" в названия таблиц
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            // Value Objects как ComplexType (чтобы EF их хранил в тех же таблицах)
            modelBuilder.ComplexType<Amount>();
            modelBuilder.ComplexType<Barcode>();
            modelBuilder.ComplexType<Description>();
            modelBuilder.ComplexType<Image>();
            modelBuilder.ComplexType<Link>();
            modelBuilder.ComplexType<Name>();
            modelBuilder.ComplexType<PIN>();
            modelBuilder.ComplexType<QR>();
            modelBuilder.ComplexType<SKU>();

            // Один-к-одному: Good → Tracking
            modelBuilder.Entity<Good>()
                .HasOptional(g => g.Tracking)
                .WithRequired(t => t.Good);

            // Один-к-одному: Good → ToBuy
            modelBuilder.Entity<Good>()
                .HasOptional(g => g.ToBuy)
                .WithRequired(t => t.Good);

            // Один-к-одному: TaskToSupply → TaskToCollect
            modelBuilder.Entity<TaskToSupply>()
                .HasOptional(s => s.TaskToCollect)
                .WithRequired(c => c.Task);

            // Один-ко-многим: TaskToSupply → TasksToPack (TaskToSupply главный)
            modelBuilder.Entity<TaskToSupply>()
                .HasMany(s => s.TasksToPack)
                .WithRequired(p => p.Task)
                .HasForeignKey(p => p.TaskToSupplyId);
        }
    }
}
