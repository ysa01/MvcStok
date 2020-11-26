using MvcStok.BLL.Repository.Entity;

namespace MvcStok.BLL.Repository.Service
{
    public class EntityService
    {
        public EntityService()
        {
            _categoryRepository = new CategoryRepository();
            _customerRepository = new CustomerRepository();
            _productRepository = new ProductRepository();
            _salesRepository = new SalesRepository();
            _userRepository = new UserRepository();
        }
        CategoryRepository _categoryRepository;
        public CategoryRepository categoryRepository
        {
            get { return _categoryRepository; }
            set { _categoryRepository = value; }

        }
        private CustomerRepository _customerRepository;
        public CustomerRepository customerRepository
        {
            get { return _customerRepository; }
            set { _customerRepository = value; }

        }
        private ProductRepository _productRepository;
        public ProductRepository productRepository
        {
            get { return _productRepository; }
            set { _productRepository = value; }

        }
        private SalesRepository _salesRepository;
        public SalesRepository salesRepository
        {
            get { return _salesRepository; }
            set { _salesRepository = value; }

        }
        private UserRepository _userRepository;
        public UserRepository userRepository
        {
            get { return _userRepository; }
            set { _userRepository = value; }

        }
    }
}
