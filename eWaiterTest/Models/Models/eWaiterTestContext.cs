using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Models.Models
{
    public partial class eWaiterTestContext : DbContext
    {
        public eWaiterTestContext()
        {
        }

        public eWaiterTestContext(DbContextOptions<eWaiterTestContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<AddressType> AddressType { get; set; }
        public virtual DbSet<Advertisement> Advertisement { get; set; }
        public virtual DbSet<AgreementSupplier> AgreementSupplier { get; set; }
        public virtual DbSet<Allergy> Allergy { get; set; }
        public virtual DbSet<CreateOrderForIngredient> CreateOrderForIngredient { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<CustomerPaymentMethod> CustomerPaymentMethod { get; set; }
        public virtual DbSet<Facility> Facility { get; set; }
        public virtual DbSet<FoodType> FoodType { get; set; }
        public virtual DbSet<Ingredient> Ingredient { get; set; }
        public virtual DbSet<IngredientStockLevel> IngredientStockLevel { get; set; }
        public virtual DbSet<IngredientSupplier> IngredientSupplier { get; set; }
        public virtual DbSet<IngredientType> IngredientType { get; set; }
        public virtual DbSet<ItemCategory> ItemCategory { get; set; }
        public virtual DbSet<ItemStatus> ItemStatus { get; set; }
        public virtual DbSet<ItemType> ItemType { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<MenuItem> MenuItem { get; set; }
        public virtual DbSet<MenuItemAllergy> MenuItemAllergy { get; set; }
        public virtual DbSet<MenuItemIngredient> MenuItemIngredient { get; set; }
        public virtual DbSet<MenuItemPrice> MenuItemPrice { get; set; }
        public virtual DbSet<MenuItemSpecial> MenuItemSpecial { get; set; }
        public virtual DbSet<OrderComment> OrderComment { get; set; }
        public virtual DbSet<OrderMenuItem> OrderMenuItem { get; set; }
        public virtual DbSet<OrderStatus> OrderStatus { get; set; }
        public virtual DbSet<OrderTable> OrderTable { get; set; }
        public virtual DbSet<PaymentMethod> PaymentMethod { get; set; }
        public virtual DbSet<PlacedOrder> PlacedOrder { get; set; }
        public virtual DbSet<PlannedShift> PlannedShift { get; set; }
        public virtual DbSet<ReorderFrequency> ReorderFrequency { get; set; }
        public virtual DbSet<Restaurant> Restaurant { get; set; }
        public virtual DbSet<RestaurantAddress> RestaurantAddress { get; set; }
        public virtual DbSet<RestaurantFacility> RestaurantFacility { get; set; }
        public virtual DbSet<RestaurantImg> RestaurantImg { get; set; }
        public virtual DbSet<RestaurantSeating> RestaurantSeating { get; set; }
        public virtual DbSet<RestaurantType> RestaurantType { get; set; }
        public virtual DbSet<RestaurantUserComment> RestaurantUserComment { get; set; }
        public virtual DbSet<Seating> Seating { get; set; }
        public virtual DbSet<Shift> Shift { get; set; }
        public virtual DbSet<Special> Special { get; set; }
        public virtual DbSet<Staff> Staff { get; set; }
        public virtual DbSet<StaffRole> StaffRole { get; set; }
        public virtual DbSet<StaffShift> StaffShift { get; set; }
        public virtual DbSet<StarRating> StarRating { get; set; }
        public virtual DbSet<StatusCatalog> StatusCatalog { get; set; }
        public virtual DbSet<Supplier> Supplier { get; set; }
        public virtual DbSet<SupplierAddress> SupplierAddress { get; set; }
        public virtual DbSet<SupplierAgreement> SupplierAgreement { get; set; }
        public virtual DbSet<UserTableBooking> UserTableBooking { get; set; }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(entity =>
            {
                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Line1)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Line2)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PostalCode)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.Province)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<AddressType>(entity =>
            {
                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Advertisement>(entity =>
            {
                entity.Property(e => e.AdvFile).HasMaxLength(1);

                entity.Property(e => e.DateActiveFrom).HasColumnType("date");

                entity.Property(e => e.DateActiveTo).HasColumnType("date");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TargetAudience).HasMaxLength(50);

                entity.HasOne(d => d.Restaurant)
                    .WithMany(p => p.Advertisement)
                    .HasForeignKey(d => d.RestaurantId)
                    .HasConstraintName("FK__Advertise__Resta__76969D2E");
            });

            modelBuilder.Entity<AgreementSupplier>(entity =>
            {
                entity.HasKey(e => new { e.SupplierAgreementId, e.SupplierId })
                    .HasName("PK__Agreemen__06F8FAC3EEAB6F7B");

                entity.ToTable("Agreement_Supplier");

                entity.HasOne(d => d.SupplierAgreement)
                    .WithMany(p => p.AgreementSupplier)
                    .HasForeignKey(d => d.SupplierAgreementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Agreement__Suppl__4BAC3F29");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.AgreementSupplier)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Agreement__Suppl__4CA06362");
            });

            modelBuilder.Entity<Allergy>(entity =>
            {
                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CreateOrderForIngredient>(entity =>
            {
                entity.HasKey(e => e.IngredientId)
                    .HasName("PK__CreateOr__BEAEB25A0656D618");

                entity.Property(e => e.IngredientId).ValueGeneratedOnAdd();

                entity.Property(e => e.OrderDate).HasColumnType("date");

                entity.HasOne(d => d.Ingredient)
                    .WithOne(p => p.CreateOrderForIngredient)
                    .HasForeignKey<CreateOrderForIngredient>(d => d.IngredientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CreateOrd__Ingre__5629CD9C");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.ConfirmationCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ContactNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ShareInfo)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CustomerPaymentMethod>(entity =>
            {
                entity.HasKey(e => new { e.CustomerId, e.PaymentMethodId, e.PlacedOrderId })
                    .HasName("PK__Customer__F6D493889DF87500");

                entity.ToTable("Customer_PaymentMethod");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerPaymentMethod)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Customer___Custo__3587F3E0");

                entity.HasOne(d => d.PaymentMethod)
                    .WithMany(p => p.CustomerPaymentMethod)
                    .HasForeignKey(d => d.PaymentMethodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Customer___Payme__367C1819");

                entity.HasOne(d => d.PlacedOrder)
                    .WithMany(p => p.CustomerPaymentMethod)
                    .HasForeignKey(d => d.PlacedOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Customer___Place__37703C52");
            });

            modelBuilder.Entity<Facility>(entity =>
            {
                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<FoodType>(entity =>
            {
                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Restaurant)
                    .WithMany(p => p.FoodType)
                    .HasForeignKey(d => d.RestaurantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__FoodType__Restau__7F2BE32F");
            });

            modelBuilder.Entity<Ingredient>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StandardCost).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.IngredientType)
                    .WithMany(p => p.Ingredient)
                    .HasForeignKey(d => d.IngredientTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Ingredien__Ingre__4F7CD00D");

                entity.HasOne(d => d.ReorderFreq)
                    .WithMany(p => p.Ingredient)
                    .HasForeignKey(d => d.ReorderFreqId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Ingredien__Reord__5070F446");
            });

            modelBuilder.Entity<IngredientStockLevel>(entity =>
            {
                entity.HasKey(e => e.IngredientId)
                    .HasName("PK__Ingredie__BEAEB25A972E6047");

                entity.Property(e => e.IngredientId).ValueGeneratedOnAdd();

                entity.Property(e => e.StockTackingDate).HasColumnType("date");

                entity.HasOne(d => d.Ingredient)
                    .WithOne(p => p.IngredientStockLevel)
                    .HasForeignKey<IngredientStockLevel>(d => d.IngredientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Ingredien__Ingre__534D60F1");
            });

            modelBuilder.Entity<IngredientSupplier>(entity =>
            {
                entity.HasKey(e => new { e.IngredientId, e.SupplierId })
                    .HasName("PK__Ingredie__EA10D4310311B346");

                entity.ToTable("Ingredient_Supplier");

                entity.Property(e => e.IngredientId).ValueGeneratedOnAdd();

                entity.Property(e => e.ValueSuppliedToDate).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Ingredient)
                    .WithMany(p => p.IngredientSupplier)
                    .HasForeignKey(d => d.IngredientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Ingredien__Ingre__59063A47");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.IngredientSupplier)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Ingredien__Suppl__59FA5E80");
            });

            modelBuilder.Entity<IngredientType>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ItemCategory>(entity =>
            {
                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ItemStatus>(entity =>
            {
                entity.Property(e => e.DateActiveFrom).HasColumnType("datetime");

                entity.Property(e => e.DateActiveTo).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ItemType>(entity =>
            {
                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.HasKey(e => new { e.RestaurantId, e.MenuItemId })
                    .HasName("PK__Menu__BFD173E718A506CB");

                entity.Property(e => e.DateActiveFrom).HasColumnType("date");

                entity.Property(e => e.DateActiveTo).HasColumnType("date");

                entity.Property(e => e.Description).HasMaxLength(60);

                entity.Property(e => e.MenuName).HasMaxLength(50);

                entity.HasOne(d => d.MenuItem)
                    .WithMany(p => p.Menu)
                    .HasForeignKey(d => d.MenuItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Menu__MenuItemId__14270015");

                entity.HasOne(d => d.Restaurant)
                    .WithMany(p => p.Menu)
                    .HasForeignKey(d => d.RestaurantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Menu__Restaurant__1332DBDC");
            });

            modelBuilder.Entity<MenuItem>(entity =>
            {
                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.ItemCategory)
                    .WithMany(p => p.MenuItem)
                    .HasForeignKey(d => d.ItemCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MenuItem__ItemCa__5CD6CB2B");

                entity.HasOne(d => d.ItemStatus)
                    .WithMany(p => p.MenuItem)
                    .HasForeignKey(d => d.ItemStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MenuItem__ItemSt__5EBF139D");

                entity.HasOne(d => d.ItemType)
                    .WithMany(p => p.MenuItem)
                    .HasForeignKey(d => d.ItemTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MenuItem__ItemTy__5DCAEF64");
            });

            modelBuilder.Entity<MenuItemAllergy>(entity =>
            {
                entity.HasKey(e => new { e.MenuItemId, e.AllergyId })
                    .HasName("PK__MenuItem__B30A1CC66690B958");

                entity.ToTable("MenuItem_Allergy");

                entity.HasOne(d => d.Allergy)
                    .WithMany(p => p.MenuItemAllergy)
                    .HasForeignKey(d => d.AllergyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MenuItem___Aller__628FA481");

                entity.HasOne(d => d.MenuItem)
                    .WithMany(p => p.MenuItemAllergy)
                    .HasForeignKey(d => d.MenuItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MenuItem___MenuI__619B8048");
            });

            modelBuilder.Entity<MenuItemIngredient>(entity =>
            {
                entity.HasKey(e => new { e.IngredientId, e.MenuItemId })
                    .HasName("PK__MenuItem__863A8D28F39BB085");

                entity.ToTable("MenuItem_Ingredient");

                entity.HasOne(d => d.Ingredient)
                    .WithMany(p => p.MenuItemIngredient)
                    .HasForeignKey(d => d.IngredientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MenuItem___Ingre__656C112C");

                entity.HasOne(d => d.MenuItem)
                    .WithMany(p => p.MenuItemIngredient)
                    .HasForeignKey(d => d.MenuItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MenuItem___MenuI__66603565");
            });

            modelBuilder.Entity<MenuItemPrice>(entity =>
            {
                entity.Property(e => e.DateFrom).HasColumnType("date");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.MenuItem)
                    .WithMany(p => p.MenuItemPrice)
                    .HasForeignKey(d => d.MenuItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MenuItemP__MenuI__693CA210");
            });

            modelBuilder.Entity<MenuItemSpecial>(entity =>
            {
                entity.HasKey(e => new { e.SpecialId, e.MenuItemId })
                    .HasName("PK__MenuItem__13CAFD1273E51B17");

                entity.ToTable("MenuItem_Special");

                entity.HasOne(d => d.MenuItem)
                    .WithMany(p => p.MenuItemSpecial)
                    .HasForeignKey(d => d.MenuItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MenuItem___MenuI__6EF57B66");

                entity.HasOne(d => d.Special)
                    .WithMany(p => p.MenuItemSpecial)
                    .HasForeignKey(d => d.SpecialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MenuItem___Speci__6E01572D");
            });

            modelBuilder.Entity<OrderComment>(entity =>
            {
                entity.Property(e => e.ComlplaintYn)
                    .IsRequired()
                    .HasColumnName("Comlplaint_YN")
                    .HasMaxLength(6);

                entity.Property(e => e.CommentDateTime).HasColumnType("datetime");

                entity.Property(e => e.CommentText)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.PlacedOrder)
                    .WithMany(p => p.OrderComment)
                    .HasForeignKey(d => d.PlacedOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OrderComm__Place__32AB8735");
            });

            modelBuilder.Entity<OrderMenuItem>(entity =>
            {
                entity.HasKey(e => new { e.PlacedOrderId, e.MenuItemId })
                    .HasName("PK__Order_Me__817F720CE3982470");

                entity.ToTable("Order_MenuItem");

                entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.FinalTotal).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.StaffTip).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.StartAmount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Vatamount)
                    .HasColumnName("VATamount")
                    .HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.MenuItem)
                    .WithMany(p => p.OrderMenuItem)
                    .HasForeignKey(d => d.MenuItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Order_Men__MenuI__3F115E1A");

                entity.HasOne(d => d.PlacedOrder)
                    .WithMany(p => p.OrderMenuItem)
                    .HasForeignKey(d => d.PlacedOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Order_Men__Place__3E1D39E1");
            });

            modelBuilder.Entity<OrderStatus>(entity =>
            {
                entity.HasKey(e => new { e.PlacedOrderId, e.StatusCatalogId })
                    .HasName("PK__Order_St__4032B121EE12BC53");

                entity.ToTable("Order_Status");

                entity.Property(e => e.DateChanged).HasColumnType("datetime");

                entity.HasOne(d => d.PlacedOrder)
                    .WithMany(p => p.OrderStatus)
                    .HasForeignKey(d => d.PlacedOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Order_Sta__Place__3A4CA8FD");

                entity.HasOne(d => d.StatusCatalog)
                    .WithMany(p => p.OrderStatus)
                    .HasForeignKey(d => d.StatusCatalogId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Order_Sta__Statu__3B40CD36");
            });

            modelBuilder.Entity<OrderTable>(entity =>
            {
                entity.Property(e => e.BillSplitYn)
                    .IsRequired()
                    .HasColumnName("BillSplit_YN")
                    .HasMaxLength(6);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PaymentMethod>(entity =>
            {
                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PlacedOrder>(entity =>
            {
                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.Total).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.OrderTable)
                    .WithMany(p => p.PlacedOrder)
                    .HasForeignKey(d => d.OrderTableId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PlacedOrd__Order__2EDAF651");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.PlacedOrder)
                    .HasForeignKey(d => d.StaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PlacedOrd__Staff__2FCF1A8A");
            });

            modelBuilder.Entity<PlannedShift>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ReorderFrequency>(entity =>
            {
                entity.Property(e => e.Frequency)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Restaurant>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(140);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.SocialMediaAddress).HasMaxLength(50);

                entity.Property(e => e.WebsiteUrl)
                    .HasColumnName("websiteUrl")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<RestaurantAddress>(entity =>
            {
                entity.HasKey(e => new { e.RestaurantId, e.AddressId })
                    .HasName("PK__Restaura__27D48E3A4548EF3D");

                entity.ToTable("Restaurant_Address");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.RestaurantAddress)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Restauran__Addre__7C4F7684");

                entity.HasOne(d => d.Restaurant)
                    .WithMany(p => p.RestaurantAddress)
                    .HasForeignKey(d => d.RestaurantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Restauran__Resta__7B5B524B");
            });

            modelBuilder.Entity<RestaurantFacility>(entity =>
            {
                entity.HasKey(e => new { e.RestaurantId, e.FacilityId })
                    .HasName("PK__Restaura__D2BE4432CDED178A");

                entity.ToTable("Restaurant_Facility");

                entity.HasOne(d => d.Facility)
                    .WithMany(p => p.RestaurantFacility)
                    .HasForeignKey(d => d.FacilityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Restauran__Facil__0B91BA14");

                entity.HasOne(d => d.Restaurant)
                    .WithMany(p => p.RestaurantFacility)
                    .HasForeignKey(d => d.RestaurantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Restauran__Resta__0A9D95DB");
            });

            modelBuilder.Entity<RestaurantImg>(entity =>
            {
                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ImageFile)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.HasOne(d => d.Restaurant)
                    .WithMany(p => p.RestaurantImg)
                    .HasForeignKey(d => d.RestaurantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Restauran__Resta__73BA3083");
            });

            modelBuilder.Entity<RestaurantSeating>(entity =>
            {
                entity.HasKey(e => new { e.RestaurantId, e.SeatingId })
                    .HasName("PK__Restaura__47B343123A296863");

                entity.ToTable("Restaurant_Seating");

                entity.HasOne(d => d.Restaurant)
                    .WithMany(p => p.RestaurantSeating)
                    .HasForeignKey(d => d.RestaurantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Restauran__Resta__06CD04F7");

                entity.HasOne(d => d.Seating)
                    .WithMany(p => p.RestaurantSeating)
                    .HasForeignKey(d => d.SeatingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Restauran__Seati__07C12930");
            });

            modelBuilder.Entity<RestaurantType>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(50);

                entity.HasOne(d => d.Restaurant)
                    .WithMany(p => p.RestaurantType)
                    .HasForeignKey(d => d.RestaurantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Restauran__Resta__10566F31");
            });

            modelBuilder.Entity<RestaurantUserComment>(entity =>
            {
                entity.ToTable("Restaurant_User_Comment");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CommentDate).HasColumnType("datetime");

                entity.Property(e => e.CommentText)
                    .IsRequired()
                    .HasMaxLength(140);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.RestaurantUserComment)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Restauran__Custo__43D61337");

                entity.HasOne(d => d.StarRating)
                    .WithMany(p => p.RestaurantUserComment)
                    .HasForeignKey(d => d.StarRatingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Restauran__StarR__44CA3770");
            });

            modelBuilder.Entity<Seating>(entity =>
            {
                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Shift>(entity =>
            {
                entity.Property(e => e.EndDateTime).HasColumnType("datetime");

                entity.Property(e => e.StartDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.PlannedShift)
                    .WithMany(p => p.Shift)
                    .HasForeignKey(d => d.PlannedShiftId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Shift__PlannedSh__18EBB532");
            });

            modelBuilder.Entity<Special>(entity =>
            {
                entity.Property(e => e.DateActiveFrom).HasColumnType("date");

                entity.Property(e => e.DateActiveTo).HasColumnType("date");

                entity.Property(e => e.SpecialPrice).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<Staff>(entity =>
            {
                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.IdNumber).HasMaxLength(13);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.Surname).HasMaxLength(50);

                entity.HasOne(d => d.Restaurant)
                    .WithMany(p => p.Staff)
                    .HasForeignKey(d => d.RestaurantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Staff__Restauran__1EA48E88");

                entity.HasOne(d => d.StaffRole)
                    .WithMany(p => p.Staff)
                    .HasForeignKey(d => d.StaffRoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Staff__StaffRole__1DB06A4F");
            });

            modelBuilder.Entity<StaffRole>(entity =>
            {
                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.HourlyRate).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<StaffShift>(entity =>
            {
                entity.HasKey(e => new { e.StaffId, e.ShiftId })
                    .HasName("PK__Staff_Sh__9ADE289F56F9DC08");

                entity.ToTable("Staff_Shift");

                entity.HasOne(d => d.Shift)
                    .WithMany(p => p.StaffShift)
                    .HasForeignKey(d => d.ShiftId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Staff_Shi__Shift__2180FB33");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.StaffShift)
                    .HasForeignKey(d => d.StaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Staff_Shi__Staff__22751F6C");
            });

            modelBuilder.Entity<StatusCatalog>(entity =>
            {
                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.Property(e => e.ContactNr).HasMaxLength(13);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PhoneNr).HasMaxLength(13);

                entity.Property(e => e.TaxNr)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<SupplierAddress>(entity =>
            {
                entity.HasKey(e => new { e.SupplierId, e.AddressTypeId, e.AddressId })
                    .HasName("PK__Supplier__B9502C5C9E0E4A06");

                entity.ToTable("Supplier_Address");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.SupplierAddress)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Supplier___Addre__03F0984C");

                entity.HasOne(d => d.AddressType)
                    .WithMany(p => p.SupplierAddress)
                    .HasForeignKey(d => d.AddressTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Supplier___Addre__02FC7413");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.SupplierAddress)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Supplier___Suppl__02084FDA");
            });

            modelBuilder.Entity<SupplierAgreement>(entity =>
            {
                entity.Property(e => e.DiscountAgreement).HasMaxLength(140);

                entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StandardPrice).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<UserTableBooking>(entity =>
            {
                entity.HasKey(e => new { e.CustomerId, e.OrderTableId })
                    .HasName("PK__User_Tab__8B2003CB9982B796");

                entity.ToTable("User_Table_Booking");

                entity.Property(e => e.DateBookingMade).HasColumnType("datetime");

                entity.Property(e => e.DateTableBookedFor).HasColumnType("datetime");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.UserTableBooking)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__User_Tabl__Custo__2B0A656D");

                entity.HasOne(d => d.OrderTable)
                    .WithMany(p => p.UserTableBooking)
                    .HasForeignKey(d => d.OrderTableId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__User_Tabl__Order__2BFE89A6");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
