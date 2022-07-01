import { Component, OnInit } from '@angular/core';
import { ShipersService } from '../service/shippers.service';
import { Shippers } from '../shippers';

@Component({
  selector: 'app-list-shippers',
  templateUrl: './list-shippers.component.html',
  styleUrls: ['./list-shippers.component.scss']
})
export class ListShippersComponent implements OnInit {

  public shippersData: Array<Shippers> = []

  constructor(
    private readonly service:ShipersService){ }

  ngOnInit(): void {
    this.getAll();
  }

  getAll(){
    this.service.getShippers().subscribe(r=> {
      this.shippersData = r;
    });
    console.log(this.service.getShippers());
    console.log("hola");
  }

  onClickDelete(id: number | undefined){
    if(id){
      this.service.deleteShippers(id).subscribe(r=> {
        this.shippersData = r;
      })
    }

  }

}
