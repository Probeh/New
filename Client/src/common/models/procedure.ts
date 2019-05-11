import { Profile } from './core/profile';
import { Solution } from './solution';

export class Procedure extends Profile<Procedure> {
  public solutionId?: number;
  public solution?: Solution;
}
