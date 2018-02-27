/**
 * Created by Fireprufe15 on 2018/02/26.
 */
import React, {Component} from 'react';
import { StackNavigator, TabNavigator, TabBarBottom } from 'react-navigation';

export const NavStack = StackNavigator({

    Login:{
        //Enter waiter code / username / whatever
    },
    FrontMenu:{
        //Select option
    },
    TableMenu:{
        //Select waiter's table
    },
    BillMenu:{
        //Select specific bill for that table if there are multiple, also ability to add more bills
    },
    BillScreen:{
        //See all current items on bill, ability to edit them, shortcut to add another one of a specific item
        //Button to add a new item
    },
    ItemList:{
        //See entire menu, can have categories and subcategories
        //Select item from menu
    },
    ItemCustomization:{
        //If specific options are required for item these are asked here
        //Text box for customizations of items
    }

});