import { Profile } from './core/profile';
import { Company } from './company';
import { Software } from './software';
import { Service } from './service';

export class Product extends Profile<Product> {
  public companyId?: number;
  public company?: Company;
  public software?: Array<Software>;
  public services?: Array<Service>;
}
