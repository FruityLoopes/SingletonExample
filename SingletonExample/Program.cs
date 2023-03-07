// See https://aka.ms/new-console-template for more information
using SingletonExample;

//DbUtil S = new DbUtil(); 

DbUtil one = DbUtil.getInstance();
DbUtil two = DbUtil.getInstance();
DbUtil three = DbUtil.getInstance();
