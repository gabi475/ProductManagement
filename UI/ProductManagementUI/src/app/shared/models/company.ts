import { Product } from './product';
export class Company {
  id: string = '';
  name: string = '';
  CEO: string = '';
  location: string = '';
  revenue: number = 0;
  employeesNumber: number = 0;
  products: Array<Product> = new Array();
}
