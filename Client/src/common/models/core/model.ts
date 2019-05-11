export class Model<T extends Model<T>> {
    public id?: number;
    public name?: string;
    public title?: string;
    public guid?: string;
    public isActive?: boolean;
    public created?: Date;
    public activeSince?: Date;
    public activeLast?: Date;
    public parentId?: number;
    public parent?: T;
    public children: Array<T>;

    constructor(name?: string) {
        this.name = name;
    }
}