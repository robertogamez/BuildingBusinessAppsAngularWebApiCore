import { Tour } from "../../shared/tour.model";
import { Show } from "./show.model";

export class TourWithShows extends Tour{
    shows: Show[];
}