import { Component, OnInit } from '@angular/core';
import { ResourceDataService } from 'src/app/data-service';

@Component({
  selector: 'app-transaction-list',
  templateUrl: './transaction-list.component.html',
  styleUrls: ['./transaction-list.component.css']
})
export class TransactionListComponent implements OnInit {
  data!: Object;

  constructor(public transactionService: ResourceDataService) {
    transactionService.getTransactionList$;
   }

  ngOnInit(): void {
    this.transactionService.getTransactionList$().subscribe(data => this.data = data)
  }

}
