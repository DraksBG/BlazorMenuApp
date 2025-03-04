# Blazor Menu Component

A multi-level dropdown menu component for Blazor applications that supports unlimited nesting of menu items.

## Features

- **Unlimited Nesting**: Menu items can be nested to any depth
- **Position-Aware Submenus**:
  - First level submenus appear **below** their parent item
  - Deeper level submenus appear to the **right** of their parent
- **Hover Activation**: Submenus appear when hovering over parent items
- **Auto-Hiding**: Submenus automatically hide when mouse moves away
- **Visual Indicators**: Arrow symbols indicate items that have submenus (down arrow for top level, right arrow for nested levels)

## Implementation Approach

### Component Structure

The menu is implemented using three main components that work together to create the hierarchical structure:

1. **Menu**: The root container component that holds the entire menu structure
2. **MenuItems**: A container for groups of menu items
3. **MenuItem**: Individual menu items that can contain nested MenuItems

This approach was chosen for several reasons:
- It creates a clean, declarative syntax that mirrors the hierarchical nature of menus
- It makes the component easy to use and understand
- It supports unlimited nesting through recursive composition

### CSS Approach

The styling is implemented using carefully crafted CSS selectors:

- `.menu > li > .submenu` - Targets first-level submenus to position them below parents
- `.submenu .submenu` - Targets deeper-level submenus to position them to the right
- `.menu-item:hover > .submenu` - Shows submenus only when hovering over parent items

This CSS-based approach was chosen over JavaScript event handlers for performance reasons and to reduce the complexity of the component.

## Usage Example

```html
<Menu>
    <MenuItems>
        <MenuItem Text="Item 1">
            <MenuItems>
                <MenuItem Text="Item 1.1"></MenuItem>
                <MenuItem Text="Item 1.2">
                    <MenuItems>
                        <MenuItem Text="Item 1.2.1"></MenuItem>
                        <MenuItem Text="Item 1.2.2"></MenuItem>
                    </MenuItems>
                </MenuItem>
            </MenuItems>
        </MenuItem>
        <MenuItem Text="Item 2"></MenuItem>
        <MenuItem Text="Item 3"></MenuItem>
    </MenuItems>
</Menu>
```

## Project Structure

This solution consists of two main projects:

1. **BlazorMenu.Components** - The component library containing the menu components
2. **BlazorMenuApp** - The sample application that demonstrates usage of the menu components

### Component Library (BlazorMenu.Components)

- **Components/Menu.razor** - The root menu container
- **Components/MenuItems.razor** - Container for grouping menu items
- **Components/MenuItem.razor** - Individual menu item component that supports nesting
- **wwwroot/menu.css** - CSS styles for the menu
- **ExportedStyles.razor** - Component to include the library's CSS in consuming applications

### Sample Application (BlazorMenuApp)

- Shows different examples of using the menu component
- Includes documentation about the component's features and usage

## Getting Started

1. Add a reference to the BlazorMenu.Components library
2. Add `@using BlazorMenu.Components` and `@using BlazorMenu.Components.Components` to your _Imports.razor
3. Add `<BlazorMenu.Components.ExportedStyles />` to your App.razor
4. Use the Menu component as shown in the usage example

## License

MIT 