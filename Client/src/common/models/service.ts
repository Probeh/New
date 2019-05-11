import { Profile } from './core/profile';
import { Company } from './company';
import { Product } from './product';
import { Software } from './software';

export class Service extends Profile<Service>{
  public companyId?: number;
  public productId?: number;
  public softwareId?: number;
  public company?: Company;
  public product?: Product;
  public software?: Software;
}
