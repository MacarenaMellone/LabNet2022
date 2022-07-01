export class Shippers {
    ID?: number;
    Name: string;
    Phone: number;

    constructor(
        Name: string,
        Phone : number){
        this.Name = Name
        this.Phone = Phone;
    }
}
