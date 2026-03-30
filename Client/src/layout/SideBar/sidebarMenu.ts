// Innovace Intech Solution Pvt Ltd
export const sidebarMenu = [
  {
    label: "Products",
    icon: "ph-cube",
    key: "products",
    children: [
      {
        label: "Product List",
        path: "/products/list"
      },
      {
        label: "Categories",
        key: "categories",
        children: [
          {
            label: "Main Categories",
            path: "/products/categories/main"
          },
          {
            label: "Sub Categories",
            path: "/products/categories/sub"
          }
        ]
      }
    ]
  },
  {
    label: "Mail",
    icon: "ph-envelope-simple",
    path: "/mail"
  },
  {
    label: "Calendar",
    icon: "ph-calendar",
    path: "/calendar"
  },
  {
    label: "Contacts",
    icon: "ph-users-three",
    path: "/contacts"
  }
];
