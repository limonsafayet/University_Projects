#include<iostream>
#include<cstdio>
#include<cstring>
#include<algorithm>
#include<cmath>
#include<stack>
#include<list>
#include<fstream>
#include<vector>
#include<iomanip>
#include<cstdlib>
using namespace std;

class Product{
    int id;
    string name;
    double unitPrice;
    int stock;
    bool status;
public:
    Product():id(0), name(""),unitPrice(0.0), stock(0), status(0){}
    int getid(){return this->id;}
    void setid(int x){this->id = x;}
    string getname(){return this->name;}
    void setname(string str){this->name = str;}
    double getPrice(){return this->unitPrice;}
    void setPrice(double d){this->unitPrice = d;}
    int getstock(){return this->stock;}
    void setstock(int x){this->stock = x;}
    bool getstatus(){return this->status;}
    void setstatus(bool b){this->status = b;}

    bool operator==(Product& p1){
        if(this->id == p1.id){return true;}
        return false;
    }

    friend ostream& operator<<(ostream& out, Product& p);
};

list<Product> productlist;

void initializeProductList(){
    ifstream file; int id; string name; double price; int stock; bool status;
    file.open("Products.txt");
    while(file>>id>>name>>price>>stock>>status){

        Product p;
        p.setid(id); p.setname(name); p.setPrice(price); p.setstatus(status); p.setstock(stock);
        productlist.push_back(p);
    }
    file.close();
}
Product* searchById(int id){
    list<Product>::iterator i = productlist.begin();
    while(i!=productlist.end()){
        if (i->getid() == id){
            return &(*i);
        }
        i++;
    }
    return nullptr;
}
void addProduct(Product product){
    productlist.push_back(product);
}
void editProduct(Product* product, string name){
    product->setname(name);
}
void deleteProduct(Product* product){
    list<Product>::iterator i = productlist.begin();
    int x = product->getid();
    while(i!=productlist.end()){
        if (i->getid() == x){
            productlist.erase(i);
            break;
        }
        i++;
    }
}
void printProduct(Product* product){
        cout<<"ID    : "<<product->getid()<<endl;
        cout<<"Name  : "<<product->getname()<<endl;
        cout<<"Price : "<<product->getPrice()<<" tk."<<endl;
        cout<<"Stock : "<<product
        ->getstatus()<<endl;
        cout<<"Status: "<<product->getstock()<<endl;
}
void printAllProducts(){
    list<Product>::iterator i = productlist.begin();
    cout<<"==========================================="<<endl;
    cout<<"ID\tProduct\t\tPrice\tStock\tStatus"<<endl;
    cout<<"--\t-------\t\t-----\t-----\t------"<<endl;
    while(i!=productlist.end()){
        cout<<*i++;
    }
    cout<<"--------------------------------------------";
}
void save(){
    fstream file;
    list<Product>::iterator x = productlist.begin();
    file.open("Products.txt", ios::out);
    while(x!=productlist.end()){
        file<<*x++;
    }
    file.close();
}

ostream& operator<<(ostream& out, Product& p){
    out<<p.getid()<<"\t"<<p.getname()<<"\t"<<p.getPrice()<<"\t"<<p.getstock()<<"\t"<<p.getstatus()<<endl;
    return out;
}

int main(){
    int choice;
    initializeProductList();
ui:
    cout<<"==========================="<<endl;
    cout<<"  1. Search Product"<<endl;
    cout<<"  2. View ALL Products"<<endl;
    cout<<"  3. Add New Product"<<endl;
    cout<<"  4. Edit Product"<<endl;
    cout<<"  5. Delete Product"<<endl;
    cout<<"  6. Clear Screen"<<endl;
    cout<<"  7. Exit"<<endl;
    cout<<"***************************"<<endl;
    cout<<"Enter Your Choice: ";
    cin>>choice;
    cout<<"==========================="<<endl;

    switch (choice){
        case 1: {
                int x;
                cout<<"Showing Product Detail**************"<<endl;
                cout<<"Enter Product ID: ";
                cin>>x;
                Product* p;
                try {
                    p = searchById(x);
                    if (p == nullptr){throw 404;}
                    printProduct(p);
                }
                catch (int x){
                  if(x == 404){
                    cout<<"Error 404: Product Not Found !"<<endl;
                    cout<<"--------------------------------------------";}
                }
                break;}
        case 2: {
                printAllProducts();
                break;}
        case 3: {
                int id; string name; double Price; int stock; bool status;
                cout<<"Adding A Product**************"<<endl;
                cout<<"Enter Product ID: ";
                cin>>id;
                cin.ignore();
                cout<<"Enter Name: ";
                cin>>name;
                cout<<"Enter Per unit Price: ";
                cin>>Price;
                cout<<"Enter Stock: ";
                cin>>stock;
                cout<<"Enter Status: ";
                cin>>status;
                Product p;
                p.setid(id); p.setname(name);
                p.setPrice(Price);p.setstock(stock);
                p.setstatus(status);
                addProduct(p);

                cout<<endl<<"Product Added Successfully!";
                cout<<"--------------------------------------------";
                break;}
        case 4: {
                int x; string s;
                cout<<"Editing A Product**************"<<endl;
                cout<<"Enter Product ID: ";
                cin>>x;
                Product* p;
                try {
                    p = searchById(x);
                    if (p == nullptr){throw 404;}
                    cout<<"Enter new product Name: ";
                    cin>>s;
                    editProduct(p, s);
                    save();
                    cout<<endl<<"Product Edited Successfully!";
                    cout<<"--------------------------------------------";
                }
                catch (int x){
                  if(x == 404){
                    cout<<"Error 404: Product Not Found !"<<endl;
                    cout<<"--------------------------------------------";}
                }
                break;}
        case 5: {
                try {
                    int x;
                    cout<<"Deleting A Product**************"<<endl;
                    cout<<"Enter Product ID: ";
                    cin>>x;
                    Product* p;
                    p = searchById(x);
                    if (p == nullptr){throw 404;}
                    deleteProduct(p);

                    cout<<endl<<"Product Deleted Successfully!";
                    cout<<"--------------------------------------------";
                }
                catch (int x_){
                  if(x_ == 404){
                    cout<<"Error 404: Product Not Found !"<<endl;
                    cout<<"--------------------------------------------";}
                }
                break;}
        case 6: {system("CLS"); break;}
        case 7: {char ch;
                cout<<"Do you want to save the changes? (y/n) ";
                cin>>ch;
                if (ch == 'y'){save(); exit(0);}
                else exit(0);
                break;}
        default: exit(1);
        }

    goto ui;

    return 0;
}
